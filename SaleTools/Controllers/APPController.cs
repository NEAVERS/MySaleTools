﻿using BLL;
using Common;
using Common.Entities;
using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace SaleTools.Controllers
{
    public class APPController : Controller
    {
        // GET: APP
        private OrderManager _order = new OrderManager();
        private UserManager _user = new UserManager();
        private ResponseModel _response = new ResponseModel();
        private GoodsManager _goodsmanager = new GoodsManager();
        private ActiveManager _active = new ActiveManager();
        private SystemManager _system = new SystemManager();


        public string Login(string userName,string pwd)
        {
            pwd = Utils.GetMD5(pwd);
            var ip = Utils.GetUserHostAddress();
            var user = _user.Login(userName, pwd, ip);
            if (user != null)
            {
                HttpCookie cookie = new HttpCookie("UserId");
                cookie.Value = user.UserId.ToString();
                cookie.Expires = DateTime.Now.AddDays(7);
                Response.Cookies.Add(cookie);
                _response.Stutas = true;
            }
            return Utils.SerializeObject(_response);
        }

        /// <summary>
        /// 获取Cookie 中的
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string GetCookie(string name)
        {
            if(Request.Cookies[name] == null)
            {
                return "";
            }
            return Request.Cookies[name].Value.ToString();
        }

        public Guid GetManagerId(UserInfo user)
        {
            Guid userId = user.CreateUserId;
            var isAdmin = user.TypeId == (int)SystemUserType.系统管理员;
            if (isAdmin)
            {
                userId = user.UserId;
            }
            return userId;
        }

        public UserInfo GetUserInfo()
        {
            string userId = GetCookie("UserId");
            Guid id = new Guid();
            if(!Guid.TryParse(userId,out id))
            {
                id = Guid.Empty;
                return null;
            }

            var user =_user.GetUserByUserId(id);
            return user;
        }

        public string GetImgSet()
        {

            var loginUser = GetUserInfo();
            if (loginUser != null)
            {
                var imgSet = _system.GetImgSet();

                _response.Stutas = true;
                _response.Result = imgSet;
            }
            else
            {
                _response.Stutas = false;
                _response.Msg = "请先登录";
            }
            string result = Utils.SerializeObject(_response);
            return result;

        }

        /// <summary>
        /// 加载购物车
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public string LoadShoopingCarCount()
        {
            var loginUser = GetUserInfo();
            if (loginUser != null)
            {
                var managerId = GetManagerId(loginUser);
                var list = _order.GetShoppingCar(loginUser.UserId);
                var manjian = _active.CheckManjiujian(loginUser.UserId, managerId);
                var obj = new
                {
                    list = list,
                    manjian = manjian
                };
                _response.Result = obj;
                _response.Stutas = true;
            }
            else
            {
                _response.Stutas = false;
                _response.Msg = "请先登录";
            }
            string result = Utils.SerializeObject(_response);
            return result;
        }

        /// <summary>
        /// 添加商品到购物车
        /// </summary>
        /// <param name="goodId"></param>
        /// <param name="method"></param>
        /// <returns></returns>
        public string AddToShoppingCar(Guid goodId)
        {
            var loginUser = GetUserInfo();
            if (loginUser != null)
            {
                int count = 1;
                bool res = false;
                OrderItem basItem = new OrderItem();
                if (_order.IsExitInCar(goodId, loginUser.UserId, out basItem))
                {
                    count += basItem.Count;
                    res = _order.SaveOrderItem(basItem.Id, count);
                }
                else
                {
                    var model = _goodsmanager.GetGoodsWithPrice(goodId, loginUser.TypeId);
                    OrderItem item = new OrderItem();
                    item.Count = count;
                    item.CreateUserId = loginUser.UserId;
                    item.Id = Guid.NewGuid();
                    item.LessPrice = 0;
                    item.Price = model.RetailtPrice;
                    item.RealPrice = item.Price - item.LessPrice;
                    item.ProductId = model.Id;
                    item.ProductTittle = model.GoodsTittle;
                    item.TotalPrice = item.RealPrice * count;
                    item.ProductType = model.FirstTypeName;
                    item.ProductTypeId = model.FirstTypeId;
                    item.ProductId = model.Id;
                    item.BarCode = model.BarCode;
                    item.Spec = model.Spec;
                    item.Unit = model.Unit;
                    item.SupplierId = model.SupplierId;
                    item.SupplierName = model.SupplierName;
                    item.BrandId = model.BrandId;
                    item.Brand = model.BrandName;
                    res = _order.AddOrderItem(item);
                }
                _response.Result = count;
                _response.Stutas = res;
            }
            else
            {
                _response.Stutas = false;
                _response.Msg = "请先登录";
            }
            string result = Utils.SerializeObject(_response);
            return result;
        }

        /// <summary>
        /// 修改购物车中商品的数量
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="count"></param>
        /// <param name="method"></param>
        /// <returns></returns>
        public string ChangeCount(Guid itemId, int count)
        {
            var loginUser = GetUserInfo();
            if (loginUser != null)
            {
                _response.Stutas = _order.SaveOrderItem(itemId, count); 
            }
            else
            {
                _response.Stutas = false;
                _response.Msg = "请先登录";
            }
            string result = Utils.SerializeObject(_response);
            return result;
        }

        /// <summary>
        /// 删除购物车中的商品
        /// </summary>
        /// <param name="itemIds"></param>
        /// <param name="method"></param>
        /// <returns></returns>
        public string DeleteItems(Guid itemId)
        {
            var loginUser = GetUserInfo();
            if (loginUser != null)
            {
                var itemIds = new List<Guid>()
                {
                    itemId
                };
                _response.Stutas = _order.DeleteOrderItem(itemIds);
            }
            else
            {
                _response.Stutas = false;
                _response.Msg = "请先登录";
            }
            string result = Utils.SerializeObject(_response);
            return result;
        }
        /// <summary>
        /// 清空购物车
        /// </summary>
        /// <param name="itemIds"></param>
        /// <param name="method"></param>
        /// <returns></returns>
        public string ClearShoppingCar()
        {
            var loginUser = GetUserInfo();
            if (loginUser != null)
            {
                _response.Stutas = _order.ClearShopping(loginUser.UserId);
            }
            else
            {
                _response.Stutas = false;
                _response.Msg = "请先登录";
            }
            string result = Utils.SerializeObject(_response);
            return  result;
        }

        /// <summary>
        /// 获取商品类型列表
        /// </summary>
        /// <param name="parentId">上级</param>
        /// <param name="method"></param>
        /// <returns></returns>
        public string GetTypeList(string parentId)
        {
            var loginUser = GetUserInfo();
            if (loginUser != null)
            {
                Guid typeId = Utils.ParseGuid(parentId);
                var list =  _goodsmanager.GetDownGoodsType(typeId, loginUser.CreateUserId);
                _response.Result = list;
                _response.Stutas = true;
            }
            else
            {
                _response.Stutas = false;
                _response.Msg = "请先登录";
            }
            string result = Utils.SerializeObject(_response);
            return result;
        }

        
        /// <summary>
        /// 首页获取推荐商品和特价商品
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public string GetSpecialGoods()
        {
            var loginUser = GetUserInfo();
            if (loginUser != null)
            {
                string tejia = ConfigurationManager.AppSettings["tejia"].ToString();
                string xinping = ConfigurationManager.AppSettings["xinping"].ToString();
                Guid managerId = GetManagerId(loginUser);
                var Tejia = _goodsmanager.GetGoodsList(managerId, loginUser.TypeId, 1, 10, "", tejia, "", "", "", "","");
                 var Xinping = _goodsmanager.GetGoodsList(managerId, loginUser.TypeId, 1, 10, "", xinping, "", "", "", "", "");
                var obj = new
                {
                    TejiaList = Tejia,
                    XinpingList = Xinping
                };
                _response.Result = obj;
                _response.Stutas = true;
            }
            else
            {
                _response.Stutas = false;
                _response.Msg = "请先登录";
            }
            string result = Utils.SerializeObject(_response);
            return result;
            ;
        }

        /// <summary>
        /// 根据条件查询商品
        /// </summary>
        /// <param name="method"></param>
        /// <param name="key"></param>
        /// <param name="fstType"></param>
        /// <param name="secType"></param>
        /// <param name="trdType"></param>
        /// <param name="brandId"></param>
        /// <returns></returns>
        public string GetGoodsByPara(int index = 1, string key = "", string fstType = "", string secType = "", string trdType = "", string brandId = "")
        {
            var loginUser = GetUserInfo();
            if (loginUser != null)
            {
                Guid managerId = GetManagerId(loginUser);
                var goodsPager = _goodsmanager.GetGoodsList(managerId, loginUser.TypeId, index, 10, "",fstType, secType, trdType, brandId, key, "");
                _response.Result = goodsPager;
                _response.Stutas = true;
            }
            else
            {
                _response.Stutas = false;
                _response.Msg = "请先登录";
            }
            string result = Utils.SerializeObject(_response);
            return result;
        }

        /// <summary>
        /// 检查是否有符合的满减活动
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public string CheckManJian()
        {
            var loginUser = GetUserInfo();
            if (loginUser != null)
            {
                Guid managerId = GetManagerId(loginUser);
                var mj = _active.CheckManjiujian(loginUser.UserId, managerId);
                _response.Result = mj;
                _response.Stutas = true;
            }
            else
            {
                _response.Stutas = false;
                _response.Msg = "请先登录";
            }
            string result = Utils.SerializeObject(_response);
            return result;
        }
        /// <summary>
        /// 检查是否有符合的满送活动
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public string CheckManSong()
        {
            var loginUser = GetUserInfo();
            if (loginUser != null)
            {
                Guid managerId = GetManagerId(loginUser);
                var ms = _active.CheckManSong(loginUser.UserId, managerId);
                _response.Result = ms;
                _response.Stutas = true;
            }
            else
            {
                _response.Stutas = false;
                _response.Msg = "请先登录";
            }
            string result = Utils.SerializeObject(_response);
            return result;
        }

        /// <summary>
        /// 获取可用的优惠卷
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public string CheckCanUseCoupon()
        {
            var loginUser = GetUserInfo();
            if (loginUser != null)
            {
                Guid managerId = GetManagerId(loginUser);
                var couponList = _active.FindCanUseCoupon(loginUser.UserId);
                _response.Result = couponList;
                _response.Stutas = true;
            }
            else
            {
                _response.Stutas = false;
                _response.Msg = "请先登录";
            }
            string result = Utils.SerializeObject(_response);
            return result;
        }

        /// <summary>
        /// 获取用户拥有的优惠券
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public string GetCoupons()
        {
            var loginUser = GetUserInfo();
            if (loginUser != null)
            {
                Guid managerId = GetManagerId(loginUser);
                var couponList = _active.GetCouponByUserId(loginUser.UserId);
                _response.Result = couponList;
                _response.Stutas = true;
            }
            else
            {
                _response.Stutas = false;
                _response.Msg = "请先登录";
            }
            string result = Utils.SerializeObject(_response);
            return result;
        }

        public string GetReceiveInfo()
        {
            var loginUser = GetUserInfo();
            if (loginUser != null)
            {
                var obj = new
                {
                    info = loginUser.ReceiveName + "   " + loginUser.Tel,
                    addr = loginUser.Province + " " + loginUser.City + " " + loginUser.Area + " " + loginUser.Addr
                };
                _response.Result = obj;
                _response.Stutas = true;
            }
            else
            {
                _response.Stutas = false;
                _response.Msg = "请先登录";
            }
            string result = Utils.SerializeObject(_response);
            return result;
        }


        /// <summary>
        /// 创建订单
        /// </summary>
        /// <param name="method"></param>
        /// <param name="remark"></param>
        /// <param name="couponId"></param>
        /// <returns></returns>
        public string CreateOrder( string remark = "", string couponId = "")
        {
            var loginUser = GetUserInfo();
            if (loginUser != null)
            {
                Guid managerId = GetManagerId(loginUser);

                var order = new OrderInfo();
                var saleMan = _user.GetUserByUserId(loginUser.SaleManGuid);
                order.Id = Guid.NewGuid();
                order.CreateTime = DateTime.Now;
                order.CreateUserId = loginUser.UserId;
                order.CreateUserName = loginUser.UserName;
                order.CreateUserType = loginUser.TypeName;
                order.CreateUserNum = loginUser.UserNum;
                order.StoreName = loginUser.SotreName;
                order.CreateUserTel = loginUser.Tel;
                order.CreateUserTypeId = loginUser.TypeId;
                order.RootUserId = loginUser.CreateUserId;
                order.RootUserName = loginUser.CreateUser;
                order.SaleManGuid = loginUser.SaleManGuid;
                order.SaleManName = loginUser.SaleManName;
                order.ReceiveAddr = loginUser.Addr;
                order.Province = loginUser.Province;
                order.ProvinceNum = loginUser.ProvinceNum;
                order.City = loginUser.City;
                order.CityNum = loginUser.CityNum;
                order.Area = loginUser.Area;
                order.AreaNum = loginUser.AreaNum;
                order.Stutas = (int)Common.Entities.OrderStatus.等待商家发货;
                order.SaleManTel = saleMan == null ? "" : saleMan.Tel;
                order.PayType = "货到付款";
                order.Remark = remark;

                Guid Cid = new Guid();

                if (Guid.TryParse(couponId, out Cid))
                {
                    Coupon c = _active.GetCouponById(Cid);
                    if (c != null)
                    {
                        order.LessMoney += c.LessMoney;
                        _active.SetCouponUse(Cid, order.Id);
                    }
                }

                Manjiujian mj = _active.CheckManjiujian(loginUser.UserId, managerId);
                Manjiusong ms = _active.CheckManSong(loginUser.UserId, managerId);
                if (mj != null)
                {
                    order.LessMoney = mj.LessMoeny;
                }
                if (ms != null)
                {
                    var model = _goodsmanager.GetGoodsWithPrice(ms.SendGoodId, loginUser.TypeId);
                    OrderItem item = new OrderItem();
                    item.Count = ms.SendGoodCount;
                    item.CreateUserId = loginUser.UserId;
                    item.Id = Guid.NewGuid();
                    item.LessPrice = 0;
                    item.Price = model.RetailtPrice;
                    item.RealPrice = 0;
                    item.ProductId = model.Id;
                    item.ProductTittle = model.GoodsTittle;
                    item.TotalPrice = 0;
                    item.ProductType = model.FirstTypeName;
                    item.ProductTypeId = model.FirstTypeId;
                    item.ProductId = model.Id;
                    item.BarCode = model.BarCode;
                    item.Spec = model.Spec;
                    item.Unit = model.Unit;
                    item.SupplierId = model.SupplierId;
                    item.SupplierName = model.SupplierName;
                    item.BrandId = model.BrandId;
                    item.Brand = model.BrandName;
                    var res = _order.AddOrderItem(item);
                }
                var ress = _order.SaveOrder(order);
                if(ress)
                {
                    string baseSupplier = ConfigurationManager.AppSettings["baseSupplierId"].ToString();
                    int baseSupplierId = Utils.ParseInt(baseSupplier);
                    var orderDetail = _order.InsertErp(order.Id, baseSupplierId);
                }
                _response.Stutas = ress;
            }
            else
            {
                _response.Stutas = false;
                _response.Msg = "请先登录";
            }
            string result = Utils.SerializeObject(_response);
            return result;
        }

        /// <summary>
        /// 获取订单列表
        /// </summary>
        /// <param name="method"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public string GetBuyList(int index,int stutas)
        {
            var loginUser = GetUserInfo();
            if (loginUser != null)
            {

                var list = _order.GetOrderListPage(loginUser.UserId,index,stutas);
                var q = from c in list
                        select new
                        {
                            OrderId = c.Id,
                            OrderNum = c.OrderNum,
                            OrderImg = _order.GetOrderDetail(c.Id).Items.FirstOrDefault().Pic,
                            GoodsTittle = _order.GetOrderDetail(c.Id).Items.FirstOrDefault().ProductTittle,
                            Count = _order.GetOrderDetail(c.Id).Items.Count,
                            TotalPrice = Math.Round( c.RealMoney,2),
                            CreateTime = c.CreateTime.ToString("yyyy-MM-dd HH:mm:ss"),
                            Stutas = c.Stutas,
                            StutasName = ((OrderStatus)c.Stutas).ToString(),
                        };
                _response.Result = q;
                _response.Stutas = true;
            }
            else
            {
                _response.Stutas = false;
                _response.Msg = "请先登录";
            }
            string result = Utils.SerializeObject(_response);
            return result;
        }


        public string CancelOrder(Guid orderId)
        {
            var response = _order.UserCancelOrder(orderId);
            return Utils.SerializeObject(response);
        }

        public string GetOneMoreOrder(Guid orderId)
        {
            var loginUser = GetUserInfo();
            if (loginUser != null)
            {
                var model = _order.ReBuy(orderId);
                _response.Result = model;
                _response.Stutas = true;
            }
            else
            {
                _response.Stutas = false;
                _response.Msg = "请先登录";
            }
            string result = Utils.SerializeObject(_response);
            return result;
        }

        public string GetOrderDetail(Guid orderid)
        {
            var loginUser = GetUserInfo();
            if (loginUser != null)
            {
                var model = _order.GetOrderDetail(orderid);
                _response.Result = model;
                _response.Stutas = true;
            }
            else
            {
                _response.Stutas = false;
                _response.Msg = "请先登录";
            }
            string result = Utils.SerializeObject(_response);
            return result;
        }

        public string GetGoodsDetail(Guid goodsId)
        {
            var loginUser = GetUserInfo();
            if (loginUser != null)
            {
                var model = _goodsmanager.GetGoodInfoById(goodsId);
                _response.Result = model;
                _response.Stutas = true;
            }
            else
            {
                _response.Stutas = false;
                _response.Msg = "请先登录";
            }
            string result = Utils.SerializeObject(_response);
            return result;
        }
        /// <summary>
        /// 获取公告列表
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public string  GetNoticeList()
        {
            var loginUser = GetUserInfo();
            if (loginUser != null)
            {
                List<Notice> list = _system.GetNoticeForShow(loginUser.TypeId, ViewBag.ManagerId);
                _response.Result = list;
                _response.Stutas = true;
            }
            else
            {
                _response.Stutas = false;
                _response.Msg = "请先登录";
            }
            string result = Utils.SerializeObject(_response);
            return result;
        }

        /// <summary>
        /// 根据Id 获取公告详情
        /// </summary>
        /// <param name="id"></param>
        /// <param name="method"></param>
        /// <returns></returns>
        public string GetNoticeDetail(int id)
        {
            var loginUser = GetUserInfo();
            if (loginUser != null)
            {
                var model = _system.GetNoticeById(id);
                _response.Result = model;
                _response.Stutas = true;
            }
            else
            {
                _response.Stutas = false;
                _response.Msg = "请先登录";
            }
            string result = Utils.SerializeObject(_response);
            return result;
        }
    }
}