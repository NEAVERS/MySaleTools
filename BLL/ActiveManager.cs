﻿using Common;
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
            var canUseCoupons = GetCouponByUserId(userid, true, true, true);
            if (canUseCoupons != null && canUseCoupons.Count < 1)
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
                var newArea = new ManToArea();
                newArea.ActiveId = model.Id;
                newArea.ActiveName = string.Empty;
                newArea.AreaNum = area.Num;
                newArea.AreaName = area.Name;
                list.Add(newArea);
            });
            _context.ManToAreas.AddRange(list);
            _context.Manjiujians.Add(model);
            _response.Stutas = _context.SaveChanges() > 0;
            return _response;
        }

        public void GetCanUserArea(List<string> res,string num)
        {
            res.Add(num);
            var area = _context.Areas.Where(x => x.ParentNum == num);
            if (area == null||area.Count()<1)
                return;
            var list = area.ToList();
            foreach(var item in list)
            {
                GetCanUserArea(res,item.Num);
            }
        }


        public List<string> GetActiveArea(Guid activeId)
        {
            var areas = _context.ManToAreas.Where(x => x.ActiveId == activeId).ToList();
            List<string> canUseArea = new List<string>();
            foreach(var item in areas)
            {
                GetCanUserArea(canUseArea, item.AreaNum);
            }
            return canUseArea;
            

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
            var orderItems = _context.OrderItems.Where(x => x.CreateUserId == userId && x.IsInShoppingCar && !x.IsDelete);
            var user = _context.UserInfoes.FirstOrDefault(x => x.UserId == userId);
            var q = from c in _context.Manjiujians
                    where c.StartTime < DateTime.Now
                    && c.EndTime > DateTime.Now
                    && c.CreateUserId == managerId
                    select c;
            var manjianList = q.ToList();
            if (manjianList == null || manjianList.Count < 1)
                return null;
            decimal total = orderItems.Sum(x => x.TotalPrice);

            var resManjian = new List<Manjiujian>();
            foreach (var item in manjianList)
            {
                List<string> areas = GetActiveArea(item.Id);
                if (areas.Contains(user.AreaNum))
                    resManjian.Add(item);
            }

            return resManjian.Where(x=>x.LimitMoney<total).OrderByDescending(x=>x.LimitMoney).FirstOrDefault();
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
                var newArea = new ManToArea();
                newArea.ActiveId = model.Id;
                newArea.ActiveName = model.Tittle;
                newArea.AreaNum = area.Num;
                newArea.AreaName = area.Name;
                list.Add(newArea);
            });
            _context.ManToAreas.AddRange(list);
            _context.Manjiusongs.Add(model);
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
                if (areas.Contains(user.AreaNum))
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


    }
}