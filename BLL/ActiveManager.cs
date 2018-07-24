using Common;
using Common.Entities;
using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ActiveManager
    {
        private SaleToolsContext _context = new SaleToolsContext();
        private ResponseModel _response = new ResponseModel();

        /// <summary>
        /// 按照用户编号 创建优惠卷
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ResponseModel CreateCoupon(Coupon model,List<UserInfo> users)
        {
            List<string> errorNum = new List<string>();
            foreach(var user in users)
            {
                var tempModel = Utils.DeepCopyByReflect(model);
                tempModel.Id = Guid.NewGuid();
                tempModel.UserId = user.UserId;
                tempModel.UserName = user.UserName;
                tempModel.UserNum = user.UserNum;
                tempModel.StoreId = user.UserId;
                tempModel.StoreNum = user.UserNum;
                _context.Coupons.Add(tempModel);
            }
            _response.Stutas = _context.SaveChanges() > 0;
            _response.Result = errorNum;
            return _response;
        }

        /// <summary>
        /// 按照用户类型创建优惠卷
        /// </summary>
        /// <param name="model"></param>
        /// <param name="UserTypes"></param>
        /// <returns></returns>

        public ResponseModel CreateCoupon(Coupon model, List<int> UserTypes)
        {
            var userList = _context.UserInfoes.Where(x => !x.IsDelete && UserTypes.Contains(x.TypeId));
            foreach (var user in userList)
            {
                var tempModel = Utils.DeepCopyByReflect(model);
                tempModel.UserId = user.UserId;
                tempModel.UserName = user.UserName;
                tempModel.UserNum = user.UserNum;
                _context.Coupons.Add(tempModel);

            }
            _response.Stutas = _context.SaveChanges() > 0;
            return _response;
        }

        public ResponseModel UpdateCouponEndTime(Guid id,DateTime endTime)
        {
            var model = _context.Coupons.FirstOrDefault(x => x.Id == id);
            if(model!=null)
            {
                model.EndTime = endTime;
            }
            _response.Stutas = _context.SaveChanges() > 0;
            return _response;
        }
        /// <summary>
        /// 根据用户Id获取优惠券
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="isUsed"></param>
        /// <param name="isCheckUsed"></param>
        /// <returns></returns>
        public List<Coupon> GetCouponByUserId(Guid userId, bool isCheckOnTime = false , bool isUsed =true, bool isCheckUsed  =false )
        {
            var q = from c in _context.Coupons
                    where c.UserId == userId
                    select c;
            if (isCheckUsed)
                q = q.Where(x => x.IsUsed == isUsed);
            if (isCheckOnTime)
                q = q.Where(x => x.StartTime < DateTime.Now && x.EndTime > DateTime.Now);
            return q.ToList();
        }

        /// <summary>
        /// 获取管理员账号下所有用户的优惠券
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="isUsed"></param>
        /// <param name="isCheckUsed"></param>
        /// <returns></returns>
        public List<Coupon> GetCouponByManagerId(Guid userId, bool isUsed = true, bool isCheckUsed = false)
        {
            var q = from c in _context.Coupons
                    join d in _context.UserInfoes on c.UserId equals d.UserId
                    where d.CreateUserId == userId
                    select c;
            if (isCheckUsed)
                q = q.Where(x => x.IsUsed == isUsed);
            return q.ToList();
        }


        public ResponseModel SetCouponUse(Guid couponId,Guid orderId)
        {
            var coupon = _context.Coupons.FirstOrDefault(x => x.Id == couponId && !x.IsUsed);
            if(coupon!= null)
            {
                coupon.IsUsed = true;
                coupon.UseTime = DateTime.Now;
                coupon.UserOrderId = orderId;
                _response.Stutas = _context.SaveChanges() > 0;
                _response.Msg = "使用优惠券失败，请刷新后重试";
            }
            else
            {
                _response.Msg = "该优惠券不存在或者已被使用！";
            }
            return _response;
        }

        /// <summary>
        /// 查找可用的优惠券
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public List<Coupon> FindCanUseCoupon(Guid   userid)
        {
            var couponList = new List<Coupon>();
            var orderItems = _context.OrderItems.Where(x => x.CreateUserId == userid && x.IsInShoppingCar && !x.IsDelete);
            var canUseCoupons = GetCouponByUserId(userid, true, false, true);
            if (canUseCoupons != null && canUseCoupons.Count > 1)
            {

                foreach (var coupon in canUseCoupons)
                {
                    #region 判断是否有对应类型的优惠券可用
                    if (coupon.CouponType == (int)CouponType.通用券)
                    {
                        decimal total = orderItems.Sum(x => x.TotalPrice);
                        if (coupon.Limit < total)
                        {
                            couponList.Add(coupon);
                            continue;
                        }
                    }

                    if (coupon.CouponType == (int)CouponType.供应商券)
                    {
                        decimal total = orderItems.Where(x=>x.SupplierId == coupon.SupplierId).Sum(x => x.TotalPrice);
                        if (coupon.Limit < total)
                        {
                            couponList.Add(coupon);
                            continue;
                        }
                    }
                    if (coupon.CouponType == (int)CouponType.品牌券)
                    {
                        decimal total = orderItems.Where(x => x.BrandId == coupon.BrandId).Sum(x => x.TotalPrice);
                        if (coupon.Limit < total)
                        {
                            couponList.Add(coupon);
                        }
                    }
                    #endregion
                }
            }
            return couponList;
        }

        /// <summary>
        /// 创建满就减活动
        /// </summary>
        /// <param name="model"></param>
        /// <param name="areNum"></param>
        /// <returns></returns>
        public ResponseModel CreateManjiujian(Manjiujian model,List<string> areNum)
        {

            List<ManToArea> list = new List<ManToArea>();
            areNum.ForEach(x =>
            {
                var area = _context.Areas.FirstOrDefault(c => c.Num == x);
                if (area != null)
                {

                    var newArea = new ManToArea();
                    newArea.ActiveId = model.Id;
                    newArea.ActiveName = string.Empty;
                    newArea.AreaNum = area.Num;
                    newArea.AreaName = area.Name;
                    list.Add(newArea);
                }
            });
            _context.ManToAreas.AddRange(list);
            _context.Manjiujians.Add(model);
            _response.Stutas = _context.SaveChanges() > 0;
            return _response;
        }
        public ResponseModel SaveManjiujian(Manjiujian model, List<string> areNum)
        {

            List<ManToArea> list = new List<ManToArea>();
            var areaHis = _context.ManToAreas.Where(x => x.ActiveId == model.Id);
            areNum.ForEach(x =>
            {
                var area = _context.Areas.FirstOrDefault(c => c.Num == x);
                if (area != null)
                {

                    var newArea = new ManToArea();
                    newArea.ActiveId = model.Id;
                    newArea.ActiveName = string.Empty;
                    newArea.AreaNum = area.Num;
                    newArea.AreaName = area.Name;
                    list.Add(newArea);
                }
            });
            var modelHis = _context.Manjiujians.FirstOrDefault(x => x.Id == model.Id);
            modelHis.StartTime = model.StartTime;
            modelHis.EndTime = model.EndTime;
            modelHis.LimitMoney = model.LimitMoney;
            modelHis.LessMoeny = model.LessMoeny;
            modelHis.UserTypes = model.UserTypes;
            modelHis.BrandId = model.BrandId;
            modelHis.BrandName = model.BrandName;
            modelHis.SupplierId = model.SupplierId;
            modelHis.SupplierName = model.SupplierName;
            modelHis.TypeId = model.TypeId;
            _context.ManToAreas.RemoveRange(areaHis);
            _context.ManToAreas.AddRange(list);
            _response.Stutas = _context.SaveChanges() > 0;
            return _response;
        }        /// <summary>

        public List<Area> GetCanUserArea(List<string> res)
        {
            var areas = _context.Areas.Where(x => res.Contains(x.Num));
            return areas.ToList();
        }


        public List<string> GetActiveArea(Guid activeId)
        {
            var areas = _context.ManToAreas.Where(x => x.ActiveId == activeId).ToList();
            List<string> canUseArea = new List<string>();
            foreach(var item in areas)
            {
                canUseArea.Add(item.AreaNum);
            }
            return canUseArea;
            

    }

        public Coupon GetCouponById(Guid couponId)
        {
            return _context.Coupons.FirstOrDefault(x => x.Id == couponId && !x.IsUsed);
        }


        

    /// <summary>
    /// 检查是否有可用的满减活动
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="managerId"></param>
    /// <returns></returns>
    public Manjiujian CheckManjiujian(Guid userId,Guid managerId)
        {
            var couponList = new List<Coupon>();
            var orderItems = _context.OrderItems.Where(x => x.CreateUserId == userId && x.IsInShoppingCar && !x.IsDelete).ToList();
            if (orderItems == null || orderItems.Count() < 1)
                return null;
            var user = _context.UserInfoes.FirstOrDefault(x => x.UserId == userId);
            var q = from c in _context.Manjiujians
                    where c.StartTime < DateTime.Now
                    && c.EndTime > DateTime.Now
                    && c.CreateUserId == managerId
                    select c;
            var manjianList = q.ToList();
            if (manjianList == null || manjianList.Count < 1)
                return null;

            var resManjian = new List<Manjiujian>();
            foreach (var item in manjianList)
            {
                List<string> areas = GetActiveArea(item.Id);
                if (areas.Contains(user.AreaNum) && item.UserTypes.Contains(user.TypeId.ToString()))
                    resManjian.Add(item);
            }


            var canUserActive = new List<Manjiujian>();
            foreach (var active in resManjian)
            {
                if (active.TypeId == (int)CouponType.通用券)
                {
                    decimal total = orderItems.Sum(x => x.TotalPrice);
                    if (active.LimitMoney < total)
                    {
                        canUserActive.Add(active);
                        continue;
                    }
                }
                if (active.TypeId == (int)CouponType.供应商券)
                {
                    decimal total = orderItems.Where(x => x.SupplierId == active.SupplierId).Sum(x => x.TotalPrice);
                    if (active.LimitMoney < total)
                    {
                        canUserActive.Add(active);
                        continue;
                    }

                }
                if (active.TypeId == (int)CouponType.品牌券)
                {
                    decimal total = orderItems.Where(x => x.BrandId == active.BrandId).Sum(x => x.TotalPrice);
                    if (active.LimitMoney < total)
                    {
                        canUserActive.Add(active);
                        continue;
                    }

                }
            }
            return canUserActive.OrderByDescending(x => x.LimitMoney).FirstOrDefault();
        }



        /// <summary>
        /// 创建满就减活动
        /// </summary>
        /// <param name="model"></param>
        /// <param name="areNum"></param>
        /// <returns></returns>
        public ResponseModel CreateManjiusong(Manjiusong model, List<string> areNum)
        {

            List<ManToArea> list = new List<ManToArea>();
            areNum.ForEach(x =>
            {
                var area = _context.Areas.FirstOrDefault(c => c.Num == x);
                if (area != null)
                {
                    var newArea = new ManToArea();
                    newArea.ActiveId = model.Id;
                    newArea.ActiveName = model.Tittle;
                    newArea.AreaNum = area.Num;
                    newArea.AreaName = area.Name;
                    list.Add(newArea);
                }
            });
            _context.ManToAreas.AddRange(list);
            _context.Manjiusongs.Add(model);
            _response.Stutas = _context.SaveChanges() > 0;
            return _response;
        }

        /// <summary>
        /// 保存满就送
        /// </summary>
        /// <param name="model"></param>
        /// <param name="areNum"></param>
        /// <returns></returns>
        public ResponseModel SaveManjiusong(Manjiusong model, List<string> areNum)
        {

            List<ManToArea> list = new List<ManToArea>();
            var areaHis = _context.ManToAreas.Where(x => x.ActiveId == model.Id);
            areNum.ForEach(x =>
            {
                var area = _context.Areas.FirstOrDefault(c => c.Num == x);
                if (area != null)
                {

                    var newArea = new ManToArea();
                    newArea.ActiveId = model.Id;
                    newArea.ActiveName = model.Tittle;
                    newArea.AreaNum = area.Num;
                    newArea.AreaName = area.Name;
                    list.Add(newArea);
                }
            });
            var modelHis = _context.Manjiusongs.FirstOrDefault(x => x.Id == model.Id);
            modelHis.Tittle = model.Tittle;
            modelHis.StartTime = model.StartTime;
            modelHis.EndTime = model.EndTime;
            modelHis.LimitMoney = model.LimitMoney;
            modelHis.SendGoodCount = model.SendGoodCount;
            modelHis.SendGoodId = model.SendGoodId;
            modelHis.SendGoodName = model.SendGoodName;
            modelHis.SendGoodNum = model.SendGoodNum;
            modelHis.UserTypes = model.UserTypes;
            modelHis.BrandId = model.BrandId;
            modelHis.BrandName = model.BrandName;
            modelHis.SupplierId = model.SupplierId;
            modelHis.SupplierName = model.SupplierName;
            modelHis.TypeId = model.TypeId;
            _context.ManToAreas.RemoveRange(areaHis);
            _context.ManToAreas.AddRange(list);
            _response.Stutas = _context.SaveChanges() > 0;
            return _response;
        }
        /// <summary>
        /// 检查是否符合满就送
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="managerId"></param>
        /// <returns></returns>
        public Manjiusong CheckManSong(Guid userId, Guid managerId)
        {
            var couponList = new List<Coupon>();
            var orderItems = _context.OrderItems.Where(x => x.CreateUserId == userId && x.IsInShoppingCar && !x.IsDelete);
            var user = _context.UserInfoes.FirstOrDefault(x => x.UserId == userId);
            if (orderItems == null || orderItems.Count() < 1)
                return null;
            var q = from c in _context.Manjiusongs
                    where c.StartTime < DateTime.Now
                    && c.EndTime > DateTime.Now
                    && c.CreateUserId == managerId
                    select c;
            var manjianList = q.ToList();
            if (manjianList == null || manjianList.Count < 1)
                return null;

            var resMansong = new List<Manjiusong>();
            foreach (var item in manjianList)
            {
                List<string> areas = GetActiveArea(item.Id);
                if (areas.Contains(user.AreaNum)&&item.UserTypes.Contains(user.TypeId.ToString()))
                    resMansong.Add(item);
            }
            if (resMansong == null || resMansong.Count < 1)
                return null;
            var canUserActive = new List<Manjiusong>();
            foreach (var active in resMansong)
            {
                if (active.TypeId == (int)CouponType.通用券)
                {
                    decimal total = orderItems.Sum(x => x.TotalPrice);
                    if (active.LimitMoney < total)
                    {
                        canUserActive.Add(active);
                        continue;
                    }
                }
                if (active.TypeId == (int)CouponType.供应商券)
                {
                    decimal total = orderItems.Where(x=>x.SupplierId == active.SupplierId).Sum(x => x.TotalPrice);
                    if (active.LimitMoney < total)
                    {
                        canUserActive.Add(active);
                        continue;
                    }

                }
                if (active.TypeId == (int)CouponType.品牌券)
                {
                    decimal total = orderItems.Where(x => x.BrandId == active.BrandId).Sum(x => x.TotalPrice);
                    if (active.LimitMoney < total)
                    {
                        canUserActive.Add(active);
                        continue;
                    }

                }
            }
            return canUserActive.OrderByDescending(x => x.LimitMoney).FirstOrDefault();
        }

        /// <summary>
        /// 获取优惠卷
        /// </summary>
        /// <param name="index"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="status"></param>
        /// <param name="storeNum"></param>
        /// <param name="createUserId"></param>
        /// <returns></returns>
        public PageData<Coupon> GetCouponPager(int index,DateTime start, DateTime end,int status,string storeNum,Guid createUserId)
        {
            PageData<Coupon> page = new PageData<Coupon>();
            var q = from c in _context.Coupons
                    where c.CreateUserId == createUserId
                    &&c.CreateTime >start
                    &&c.CreateTime<end
                    select c;
            if (status != -1)
                q = q.Where(x => x.IsUsed == (status == 1));
            if (!string.IsNullOrWhiteSpace(storeNum))
                q = q.Where(x => x.UserNum == storeNum);
            page.PageIndex = index;
            page.PageSize = 30;
            page.TotalCount = q.Count();

            page.ListData = q.OrderByDescending(x => x.CreateTime).Skip((index - 1) * 30).Take(30).ToList();
            return page;
        }

        /// <summary>
        /// 获取满送活动详情
        /// </summary>
        /// <param name="activeId"></param>
        /// <returns></returns>

        public ManDetail<Manjiusong> GetManSongDetial(Guid activeId)
        {
            var detail = new ManDetail<Manjiusong>();
            detail.Info = _context.Manjiusongs.FirstOrDefault(x => x.Id == activeId);
            var areas = GetActiveArea(activeId);
            detail.areas = GetCanUserArea(areas);
            return detail;
        }

        /// <summary>
        /// 获取满减活动详情
        /// </summary>
        /// <param name="activeId"></param>
        /// <returns></returns>
        public ManDetail<Manjiujian> GetManJianDetial(Guid activeId)
        {
            var detail = new ManDetail<Manjiujian>();
            detail.Info = _context.Manjiujians.FirstOrDefault(x => x.Id == activeId);
            var areas = GetActiveArea(activeId);
            detail.areas = GetCanUserArea(areas);
            return detail;
        }

        /// <summary>
        /// 获取满减列表
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public PageData<Manjiujian> GetManJianPager(Guid userid,int index)
        {
            var q = from c in _context.Manjiujians
                    where c.CreateUserId == userid
                    select c;
            var pager = new PageData<Manjiujian>();
            pager.PageIndex = index;
            pager.PageSize = 30;
            pager.TotalCount = q.Count();
            pager.ListData = q.OrderByDescending(x => x.CreateTime).Skip((index - 1) * 30).Take(30).ToList();
            foreach(var item in pager.ListData)
            {
                var areas = GetActiveArea(item.Id);
                var areaList = GetCanUserArea(areas);
                item.SupplierName = string.Join(",", areaList.Select(x => x.Name));
                var userTypes = GetUserType(item.UserTypes);
                item.UserTypes = string.Join(",", userTypes.Select(x => x.TypeName));
            }
            return pager;
        }
        /// <summary>
        /// 获取满送活动列表
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public PageData<Manjiusong> GetManSongPager(Guid userid, int index)
        {
            var q = from c in _context.Manjiusongs
                    where c.CreateUserId == userid
                    select c;
            var pager = new PageData<Manjiusong>();
            pager.PageIndex = index;
            pager.PageSize = 30;
            pager.TotalCount = q.Count();
            pager.ListData = q.OrderByDescending(x => x.CreateTime).Skip((index - 1) * 30).Take(30).ToList();
            foreach (var item in pager.ListData)
            {
                var areas = GetActiveArea(item.Id);
                var areaList = GetCanUserArea(areas);
                item.SupplierName = string.Join(",", areaList.Select(x => x.Name));
                var userTypes = GetUserType(item.UserTypes);
                item.UserTypes = string.Join(",", userTypes.Select(x => x.TypeName));
            }
            return pager;
        }

        /// <summary>
        /// 获取用户类型列表
        /// </summary>
        /// <param name="types"></param>
        /// <returns></returns>
        public List<UserType> GetUserType(string types)
        {
            var typeArr = types.Split(',');
            var list = new List<UserType>();
            foreach (StoreUserType type in Enum.GetValues(typeof(StoreUserType)))
            {
                var model = new UserType();
                model.TypeId = (int)type;
                model.TypeName = type.ToString();
                model.IsAdmin = false;
                list.Add(model);
            }
            var res = list.Where(x => typeArr.Contains(x.TypeId.ToString()));
            return res.ToList();
        }
        /// <summary>
        /// 获取我的优惠卷
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<Coupon> GetMyCoupons(Guid userId,int type)
        {
            var q = from c in _context.Coupons
                    where c.UserId == userId
                    select c;
            if (type == 0)
                q = q.Where(x => !x.IsUsed && x.StartTime < DateTime.Now && x.EndTime > DateTime.Now);
            if (type == 1)
                q = q.Where(x => x.IsUsed);
            if (type == 2)
                q = q.Where(x => !x.IsUsed && x.EndTime < DateTime.Now);
            return q.ToList();

        }

        /// <summary>
        /// 检查是否能买
        /// </summary>
        /// <param name="goodId"></param>
        /// <param name="areaNum"></param>
        /// <returns></returns>
        public bool CheckCanBuy(Guid goodId,string areaNum)
        {
            var model = _context.BlackLists.FirstOrDefault(x => x.GoodsId == goodId && !x.IsDelete);
            if(model != null)
            {
                var area = _context.ManToAreas.FirstOrDefault(x => x.ActiveId == model.Id && x.AreaNum == areaNum.Trim());
                if (area != null)///如果黑名单中存在对应的记录则不能购买
                    return false;
            }
            return true;
        }

        /// <summary>
        /// 添加类目折扣
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public bool AddDiscountInfo(DiscountInfo info,List<string> areNum)
        {

            if(info.Id == Guid.Empty)
            {
                info.Id = Guid.NewGuid();
                var model = _context.DiscountInfos.FirstOrDefault(x => x.TypeId == info.TypeId);
                if (model != null)
                    return false;
                _context.DiscountInfos.Add(info);
            }
            else
            {
                var model = _context.DiscountInfos.FirstOrDefault(x => x.Id == info.Id);
                model.StartTime = info.StartTime;
                model.EndTime = info.EndTime;
                model.Discount = info.Discount;
                model.UserTypes = info.UserTypes;
                model.TypeId = info.TypeId;
                model.TypeName = info.TypeName;
            }


            List<ManToArea> list = new List<ManToArea>();
            var areaHis = _context.ManToAreas.Where(x => x.ActiveId == info.Id);
            areNum.ForEach(x =>
            {
                var area = _context.Areas.FirstOrDefault(c => c.Num == x);
                if (area != null)
                {

                    var newArea = new ManToArea();
                    newArea.ActiveId = info.Id;
                    newArea.ActiveName = string.Empty;
                    newArea.AreaNum = area.Num;
                    newArea.AreaName = area.Name;
                    list.Add(newArea);
                }
            });
            _context.ManToAreas.RemoveRange(areaHis);
            _context.ManToAreas.AddRange(list);

            return _context.SaveChanges() > 0;
        }


        

        public List<DiscountDetail> GetDiscountList(Guid userId)
        {
            var q = _context.DiscountInfos.Where(x=>x.UpdateUserId == userId).ToList();
            var list = new List<DiscountDetail>();
            foreach(var item in q)
            {
                var model = new DiscountDetail();
                model.Info = item;
                model.Areas = _context.ManToAreas.Where(x => x.ActiveId == item.Id).ToList();
                list.Add(model);
            }
            return list;
        }

        public DiscountDetail GetDiscountDetail(Guid discountId)
        {
            var q = _context.DiscountInfos.FirstOrDefault(x => x.Id == discountId);
            if (q == null)
                return null;
            var model = new DiscountDetail();
            model.Info = q;
            model.Areas = _context.ManToAreas.Where(x => x.ActiveId == q.Id).ToList();
            return model;
        }

        /// <summary>
        /// 查询类目折扣
        /// </summary>
        /// <param name="typeId"></param>
        /// <param name="areaNum"></param>
        /// <param name="userType"></param>
        /// <returns></returns>
        public decimal CheckDiscountDetail(Guid typeId,string areaNum,string userType)
        {
            decimal discount = 100;
            var model = _context.DiscountInfos.FirstOrDefault(x => x.TypeId == typeId && x.StartTime < DateTime.Now && x.EndTime > DateTime.Now&&x.UserTypes.Contains(userType));
            if(model!=null)
            {
                var areas = _context.ManToAreas.Where(x => x.ActiveId == model.Id).ToList();
                if (areas == null || areas.Count < 1 || areas.Exists(x => x.AreaNum == areaNum))
                    discount = model.Discount;
            }
            return discount;
        }

        /// <summary>
        /// 删除类目折扣
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public ResponseModel DeleteDiscount(Guid id)
        {
            try
            {
                var model = _context.DiscountInfos.FirstOrDefault(x => x.Id == id);
                if (model != null)
                {
                    var areas = _context.ManToAreas.Where(x => x.ActiveId == id);
                    _context.DiscountInfos.Remove(model);
                    _context.ManToAreas.RemoveRange(areas);
                    _response.Stutas = _context.SaveChanges() > 0;
                }
                else
                {
                    _response.Msg = "该记录不存在请刷新后重试";
                }
            }
            catch(Exception ex)
            {
                LogsHelper.WriteErrorLog(ex, "类目折扣");
                _response.Msg = ex.Message;
            }
            return _response;
        }

        #region 黑名单功能

        /// <summary>
        /// 添加类目折扣
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public bool AddBlackList(BlackList info, List<string> areNum)
        {

            if (info.Id == Guid.Empty)
            {
                var goodsInfo = _context.GoodInfoes.FirstOrDefault(x => x.GoodsNum == info.GoodsNum);
                if (goodsInfo == null)
                    return false;
                info.GoodsName = goodsInfo.GoodsTittle;
                info.Id = Guid.NewGuid();
                info.GoodsId = goodsInfo.Id;
                var model = _context.BlackLists.FirstOrDefault(x => x.GoodsId == info.GoodsId);
                if (model != null)
                    return false;
                _context.BlackLists.Add(info);
            }

            List<ManToArea> list = new List<ManToArea>();
            var areaHis = _context.ManToAreas.Where(x => x.ActiveId == info.Id);
            areNum.ForEach(x =>
            {
                var area = _context.Areas.FirstOrDefault(c => c.Num == x);
                if (area != null)
                {

                    var newArea = new ManToArea();
                    newArea.ActiveId = info.Id;
                    newArea.ActiveName = string.Empty;
                    newArea.AreaNum = area.Num;
                    newArea.AreaName = area.Name;
                    list.Add(newArea);
                }
            });
            _context.ManToAreas.RemoveRange(areaHis);
            _context.ManToAreas.AddRange(list);

            return _context.SaveChanges() > 0;
        }




        public List<BlackListDetail> GetBlackList(Guid userId)
        {
            var q = _context.BlackLists.Where(x => x.CreateUserId == userId).ToList();
            var list = new List<BlackListDetail>();
            foreach (var item in q)
            {
                var model = new BlackListDetail();
                model.Info = item;
                model.Areas = _context.ManToAreas.Where(x => x.ActiveId == item.Id).ToList();
                model.goodInfo = _context.GoodInfoes.FirstOrDefault(x => x.Id == item.GoodsId);
                list.Add(model);
            }
            return list;
        }

        public BlackListDetail GetBlackListDetail(Guid Id)
        {
            var q = _context.BlackLists.FirstOrDefault(x => x.Id == Id);
            if (q == null)
                return null;
            var model = new BlackListDetail();
            model.Info = q;
            model.Areas = _context.ManToAreas.Where(x => x.ActiveId == q.Id).ToList();
            model.goodInfo = _context.GoodInfoes.FirstOrDefault(x => x.Id == q.GoodsId);

            return model;
        }

        /// <summary>
        /// 是否在黑名单中
        /// </summary>
        /// <param name="typeId"></param>
        /// <param name="areaNum"></param>
        /// <param name="userType"></param>
        /// <returns></returns>
        public bool CheckIsInBlack(Guid goodsId, string areaNum)
        {
            bool isInBlack = false;
            var model = _context.BlackLists.FirstOrDefault(x => x.GoodsId == goodsId);
            if (model != null)
            {
                var areas = _context.ManToAreas.Where(x => x.ActiveId == model.Id).ToList();
                if (areas == null || areas.Count < 1 || areas.Exists(x => x.AreaNum == areaNum))
                    isInBlack = true;
            }
            return isInBlack;
        }



        /// <summary>
        /// 删除类目折扣
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public ResponseModel DeleteBlackList(Guid id)
        {
            try
            {
                var model = _context.BlackLists.FirstOrDefault(x => x.Id == id);
                if (model != null)
                {
                    var areas = _context.ManToAreas.Where(x => x.ActiveId == id);
                    _context.BlackLists.Remove(model);
                    _context.ManToAreas.RemoveRange(areas);
                    _response.Stutas = _context.SaveChanges() > 0;
                }
                else
                {
                    _response.Msg = "该记录不存在请刷新后重试";
                }
            }
            catch (Exception ex)
            {
                LogsHelper.WriteErrorLog(ex, "黑名单");
                _response.Msg = ex.Message;
            }
            return _response;
        }
        #endregion

    }
}
