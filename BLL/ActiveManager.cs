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
        public ResponseModel CreateCoupon(Coupon model,List<string> userNums)
        {
            List<string> errorNum = new List<string>();
            foreach(var num in userNums)
            {
                var user = _context.UserInfoes.FirstOrDefault(c => c.UserNum == num);
                if (user == null)
                {
                    errorNum.Add(num);
                    continue;
                }
                var tempModel = Utils.DeepCopyByReflect(model);
                tempModel.UserId = user.UserId;
                tempModel.UserName = user.UserName;
                tempModel.UserNum = user.UserNum;
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
                q = q.Where(x => x.StartTime > DateTime.Now && x.EndTime < DateTime.Now);
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



    }
}
