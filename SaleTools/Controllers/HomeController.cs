﻿using BLL;
using Common;
using Common.Entities;
using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaleTools.Controllers
{
    public class HomeController : BaseController
    {

        private GoodsManager _manager = new GoodsManager();
        private OrderManager _order = new OrderManager();
        private SystemManager _system = new SystemManager();
        private UserManager _user = new UserManager();
        private ActiveManager _active = new ActiveManager();
        private ResponseModel _response = new ResponseModel();
        // GET: Home
        public ActionResult Index()
        {
            var loginUser = (UserInfo)ViewBag.User;
            var imgSet = _system.GetImgSet(loginUser.TypeId);
            ViewBag.ImgList = imgSet;
            List<Notice> list = _system.GetNoticeForShow(loginUser.TypeId, ViewBag.ManagerId);
            list = list.OrderByDescending(x => x.CreateTime).Take(6).ToList();
            string tejia = ConfigurationManager.AppSettings["tejia"].ToString();
            string xinping = ConfigurationManager.AppSettings["xinping"].ToString();

            ViewBag.Tejia = _manager.GetGoodsList(ViewBag.ManagerId, loginUser.TypeId, 1, 10000, "", tejia, "", "", "", "", "1");
            ViewBag.Xinping = _manager.GetGoodsList(ViewBag.ManagerId, loginUser.TypeId, 1, 10000, "", xinping, "", "", "", "", "1");
            ViewBag.NoticeList = list;
            return View();
        }

        public string LoadProduct(string firstTypeId)
        {
            var loginUser = (UserInfo)ViewBag.User;

            var list = _manager.GetGoodsList(ViewBag.ManagerId, loginUser.TypeId, 1, 10, "", firstTypeId, "", "", "","", "1");
            return Utils.SerializeObject(list);
        }


        public ActionResult Product(string fst = "", string sec = "", string trd = "", string brandId = "",string key = "")
        {
            var fstType = _manager.GetGoodsType(fst);
            var secType = _manager.GetGoodsType(sec);
            var trdType = _manager.GetGoodsType(trd);
            var loginUser = (UserInfo)ViewBag.User;
            string para = "fst";
            string CurrentPara = "";
            Guid parentId = Guid.Empty;
            var TypeList = new List<GoodsType>();
            var BrandList = new List<GoodsBrand>();
            if (!string.IsNullOrWhiteSpace(trd))
            {
                para = "trd";
                CurrentPara =  "trd";
                parentId = Utils.ParseGuid(trd);
                secType = _manager.GetGoodsType(trdType.ParentId.ToString());
                fstType = _manager.GetGoodsType(secType.ParentId.ToString());
            }
            else if (!string.IsNullOrWhiteSpace(sec))
            {
                para = "trd";
                CurrentPara = "sec";

                parentId = Utils.ParseGuid(sec);
                fstType = _manager.GetGoodsType(secType.ParentId.ToString());
            }
            else if (!string.IsNullOrWhiteSpace(fst))
            {
                para = "sec";
                CurrentPara = "fst";

                parentId = Utils.ParseGuid(fst);
            }
            TypeList = _manager.GetDownGoodsType(parentId, loginUser.CreateUserId);
            if (para == "trd" && !string.IsNullOrWhiteSpace(trd))
            {
                TypeList = new List<GoodsType>();
                TypeList.Add(_manager.GetGoodsType(parentId.ToString()));
            }
            BrandList = _manager.GetBrandList(parentId);
            if (!string.IsNullOrWhiteSpace(brandId))
            {
                var model = BrandList.FirstOrDefault(x => x.Id.ToString() == brandId);
                if (model != null)
                {
                    BrandList = new List<GoodsBrand>()
                    { model };
                }
            }
            ViewBag.CurrentPara = CurrentPara;
            ViewBag.TypeList = TypeList;
            ViewBag.BrandList = BrandList;
            ViewBag.Para = para;
            ViewBag.ParentGuid = parentId;
            ViewBag.FstType = fstType;
            ViewBag.SecType = secType;
            ViewBag.TrdType = trdType;
            ViewBag.brandId = brandId;
            ViewBag.fst = fst;
            ViewBag.sec = sec;
            ViewBag.trd = trd;
            ViewBag.Key = key;
            return View();

        }

        public string LoadProductList(int page, int size, string fst = "", string sec = "", string trd = "", string brandId = "", string key = "", string orderBy = "")
        {
            var loginUser = (UserInfo)ViewBag.User;
            var list = _manager.GetGoodsList(ViewBag.ManagerId, loginUser.TypeId, page,size, "", fst, sec, trd, brandId, key, "1",orderBy);
            return Utils.SerializeObject(list);
        }




        public ActionResult ProductDetail(Guid Id)
        {
            var product = _manager.GetGoodInfoById(Id);
            var loginUser = (UserInfo)ViewBag.User;
            string tittle = "";
            product.RetailtPrice = _manager.GetPriceOfUserType(product, loginUser.TypeId,out tittle);
            product.GoodsTittle = tittle;
            return View(product);
        }


        public string AddToShoppingCar(Guid goodId,int count)
        {
            
            bool res = false;
            var loginUser = (UserInfo)ViewBag.User;
            var goodsInfo = _manager.GetGoodInfoById(goodId);
            int boxspec = Utils.ParseInt(goodsInfo.BoxSpec);
            if(boxspec == 0 || !goodsInfo.IsBoxSale)
                boxspec = 1;
            decimal Stock = _manager.GetGoodsStock(goodsInfo.ErpId,boxspec);
            OrderItem basItem = new OrderItem();
            if (!_active.CheckCanBuy(goodId, loginUser.AreaNum))
            {
                _response.Msg = "您无法购买该商品！";
                return Utils.SerializeObject(_response);
            }
            if (count > Stock)
            {
                _response.Msg = "您无法购买该商品！已超过库存！";
                return Utils.SerializeObject(_response);
            }
            if (goodsInfo.LimitCount>0&& count > goodsInfo.LimitCount)
            {
                _response.Msg = "该商品限购" + goodsInfo.LimitCount;
                return Utils.SerializeObject(_response);
            }

            if (_order.IsExitInCar(goodId,loginUser.UserId, out basItem))
            {
                count += basItem.Count;
                if(count> Stock)
                {
                    _response.Msg = "您无法购买该商品！已超过库存！";
                }
                else if (goodsInfo.LimitCount > 0 && count > goodsInfo.LimitCount)
                {
                    _response.Msg = "该商品限购"+ goodsInfo.LimitCount;
                    return Utils.SerializeObject(_response);
                }
                else if(goodsInfo.MinCount > count)
                {
                    _response.Msg = "该商品最少购买" + goodsInfo.MinCount;
                    return Utils.SerializeObject(_response);
                }
                else
                    _response.Stutas = _order.SaveOrderItem(basItem.Id, count);
            }
            else
            {
                if (goodsInfo.MinCount > count)
                {
                    _response.Msg = "该商品最少购买" + goodsInfo.MinCount;
                    return Utils.SerializeObject(_response);
                }

                var model = _manager.GetGoodsWithPrice(goodId, loginUser.TypeId);
                OrderItem item = new OrderItem();
                item.Count = count;
                item.CreateUserId = loginUser.UserId;
                decimal discount = _active.CheckDiscountDetail(model.FirstTypeId, loginUser.AreaNum, loginUser.TypeId.ToString());
                if(_active.CheckInBlack(ViewBag.ManagerId,model.Id))
                {
                    discount = 100;
                }
                item.Id = Guid.NewGuid();
                item.LessPrice = Math.Round((100-discount)* model.RetailtPrice/100,10);
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
                item.Pic = model.pic1;
                _response.Stutas = _order.AddOrderItem(item);
            }
            return Utils.SerializeObject(_response);
        }


        public string LoadShoopingCarCount()
        {
            var loginUser = (UserInfo)ViewBag.User;
            var list = _order.GetShoppingCar(loginUser);
            return Utils.SerializeObject(list.Count);
        }




        public ActionResult ShoppingCar()
        {
            var loginUser = (UserInfo)ViewBag.User;
            var list = _order.GetShoppingCar(loginUser);
            var mj = _active.CheckManjiujian(loginUser, ViewBag.ManagerId);
            var ms = _active.CheckManSong(loginUser, ViewBag.ManagerId);
            var dpses = _active.CheckDPS(list,loginUser.TypeId,loginUser.AreaNum);
            ViewBag.Mj = mj;
            ViewBag.Ms = ms;
            ViewBag.List = list;
            ViewBag.DPSES = dpses;
            return View();
        }


        public string ChangeCount(Guid itemId,int count)
        {
            var orderItem = _order.GetOrderItem(itemId);
            if (orderItem != null)
            {
                var goodsInfo = _manager.GetGoodInfoById(orderItem.ProductId);
  
                int boxspec = Utils.ParseInt(goodsInfo.BoxSpec);
                if (boxspec == 0 || !goodsInfo.IsBoxSale)
                    boxspec = 1;
                decimal Stock = _manager.GetGoodsStock(goodsInfo.ErpId,boxspec);
                if (goodsInfo.LimitCount > 0 && count > goodsInfo.LimitCount)
                {
                    _response.Msg = string.Format( "该商品限购{0}！", goodsInfo.LimitCount);
                    return Utils.SerializeObject(_response);
                }
                if (Stock < count || count < 1)
                {
                    _response.Msg = string.Format("库存不足！", goodsInfo.LimitCount);
                    return Utils.SerializeObject(_response);
                }
                if ( count < goodsInfo.MinCount)
                {
                    _response.Msg = string.Format("数量不能小于最小起批数！", goodsInfo.LimitCount);
                    return Utils.SerializeObject(_response);
                }
                _response.Stutas = _order.SaveOrderItem(itemId, count);

                return Utils.SerializeObject(_response);
            }
            _response.Msg = "该商品已从订单中删除！";
            return Utils.SerializeObject(_response);
        }

        public string DeleteItems(List<Guid> itemIds)
        {
            var res = _order.DeleteOrderItem(itemIds);
            return Utils.SerializeObject(res);
        }


        public string ClearShoppingCar()
        {
            var loginUser = (UserInfo)ViewBag.User;

            var res = _order.ClearShopping(loginUser.UserId);
            return Utils.SerializeObject(res);

        }

        public ActionResult ConfirmOrder()
        {
            var loginUser = (UserInfo)ViewBag.User;
            var list = _order.GetShoppingCar(loginUser);
            var mj = _active.CheckManjiujian(loginUser, ViewBag.ManagerId);
            Manjiusong ms = _active.CheckManSong(loginUser, ViewBag.ManagerId);
            var couponList = _active.FindCanUseCoupon(loginUser.UserId);
            var dpses = _active.CheckDPS(list, loginUser.TypeId, loginUser.AreaNum);
            dpses.ForEach(x =>
            {
                var model = _manager.GetGoodInfoById(x.SendGoodsId);
                if(model!=null)
                    x.SendGoodsNum = model.pic1;
            });
            if (ms != null)
            {
                var msGoods = _manager.GetGoodInfoById(ms.SendGoodId);
                if (msGoods != null)
                    ms.Tittle = msGoods.pic1;
            }
            ViewBag.Mj = mj;
            ViewBag.Ms = ms;
            ViewBag.List = list;

            ViewBag.CouponList = couponList;
            ViewBag.DPSES = dpses;

            return View();
        }


        public string CreateOrder(string remark = "", string couponId = "")
        {
            var loginUser = (UserInfo)ViewBag.User;
            var list = _order.GetShoppingCar(loginUser);
            var totalPrice = list.Sum(x => x.Count * x.Price);
            if (list != null && list.Count > 0&& totalPrice>380)
            {
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

                Manjiujian mj = _active.CheckManjiujian(loginUser, ViewBag.ManagerId);
                Manjiusong ms = _active.CheckManSong(loginUser, ViewBag.ManagerId);
                CouponActivity ca = _active.CheckCouponActivity(loginUser, ViewBag.ManagerId);
                if (mj != null)
                {
                    order.Manjian = mj.LessMoeny;
                }
                if ((ms != null&&ca ==null)||(ms != null && ca != null &&ms.LimitMoney >ca.SendMoney))
                {
                    var model = _manager.GetGoodsWithPrice(ms.SendGoodId, loginUser.TypeId);
                    OrderItem item = new OrderItem();
                    item.IsGift = true;
                    item.Count = ms.SendGoodCount;
                    item.CreateUserId = loginUser.UserId;
                    item.Id = Guid.NewGuid();
                    item.LessPrice = 0;
                    item.Price = 0;
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
                    item.Pic = model.pic1;
                    var res = _order.AddOrderItem(item);
                }
                if ((ms == null && ca != null) || (ms != null && ca != null && ms.LimitMoney <= ca.SendMoney))
                {
                    Coupon coupon = new Coupon();
                    coupon.BrandId = ca.BrandId;
                    coupon.BrandName = ca.BrandName;
                    coupon.CouponType = ca.CouponType;
                    coupon.CreateTime = DateTime.Now;
                    coupon.CreateUserId = ca.CreateUserId;
                    coupon.CreateUserName = ca.CreateUserName;
                    coupon.EffectTime = ca.EffectTime;
                    coupon.EndTime = DateTime.Now.AddDays(coupon.EffectTime);
                    coupon.Id = Guid.NewGuid();
                    coupon.IsUsed = false;
                    coupon.LessMoney = ca.LessMoney;
                    coupon.Limit = ca.Limit;
                    coupon.Remark = ca.Remark;
                    coupon.StartTime = ca.StartTime;
                    coupon.StoreId = loginUser.UserId;
                    coupon.StoreNum = loginUser.UserNum;
                    coupon.SupplierId = ca.SupplierId;
                    coupon.SupplierName = ca.SupplierName;
                    coupon.ActivityID = ca.Id;
                    List<UserInfo> userList = new List<UserInfo>();
                    userList.Add(loginUser);
                    _active.CreateCoupon(coupon, userList);

                }
                var dpses = _active.CheckDPS(list, loginUser.TypeId, loginUser.AreaNum);
                foreach (var dps in dpses)
                {
                    var model = _manager.GetGoodsWithPrice(dps.SendGoodsId, loginUser.TypeId);
                    OrderItem item = new OrderItem();
                    item.IsGift = true;
                    item.Count = dps.SendCount;
                    item.CreateUserId = loginUser.UserId;
                    item.Id = Guid.NewGuid();
                    item.LessPrice = 0;
                    item.Price =  0 ;
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
                    item.Pic = model.pic1;
                    var res = _order.AddOrderItem(item);
                }
                _response.Stutas = _order.SaveOrder(order,loginUser);
                //保存订单成功后 保存销售订单到erp 系统中
                if (_response.Stutas)
                {
                    try
                    {

                        var res = _order.InsertErp(order.Id);
                    }
                    catch(Exception ex)
                    {
                        LogsHelper.WriteErrorLog(ex, "导入Erp");
                    }
                    
                 }
            }
            else
            {
                _response.Msg ="总金额不足380无法下单！请继续添加商品！";
            }
            return Utils.SerializeObject(_response);
        }


        public ActionResult BuyList(string start= "",string end ="")
        {
            var loginUser = (UserInfo)ViewBag.User;
            DateTime startTime = Utils.GetTime(start, true);
            DateTime endTime = Utils.GetTime(end);
            ViewBag.StartTime = startTime.ToString("yyyy-MM-dd HH:mm:ss");
            ViewBag.EndTime = endTime.ToString("yyyy-MM-dd HH:mm:ss");
            var list = _order.GetOrderListByCreateUserId(startTime, endTime, loginUser.UserId);
            ViewBag.OrderList = list;
            return View();
        }


        public string SerCollect(Guid  goodId)
        {
            var loginUser = (UserInfo)ViewBag.User;
            var res = _manager.CollectGoods(loginUser.UserId, goodId);
            return Utils.SerializeObject(res);
        }

        public ActionResult UserIndex()
        {
            var loginUser = (UserInfo)ViewBag.User;
            if(loginUser.TypeId > 0)
            {
                return RedirectToAction("UserOrderManager", "Order");
            }
            else
            {
                return RedirectToAction("Index", "User");
            }
        }

        public ActionResult Notice(int id)
        {
            var loginUser = (UserInfo)ViewBag.User;

            var model = _system.GetNoticeById(id);
            List<Notice> list = _system.GetNoticeForShow(loginUser.TypeId, ViewBag.ManagerId);
            list = list.OrderByDescending(x => x.CreateTime).ToList();
            ViewBag.NoticeList = list;
            ViewBag.NoticeId = id;
            return View();
        }

        public ActionResult NoticeDetail(int id)
        {
            var model = _system.GetNoticeById(id);
            return View(model);
        }


        public ActionResult HomeIndex()
        {
            return View();
        }
    }
}