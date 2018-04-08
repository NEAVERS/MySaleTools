using BLL;
using Common;
using Model;
using System;
using System.Collections.Generic;
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
        // GET: Home
        public ActionResult Index()
        {
            var imgSet = _system.GetImgSet();
            ViewBag.ImgList = imgSet;
            return View();
        }

        public string LoadProduct(string firstTypeId)
        {
            var loginUser = (UserInfo)ViewBag.User;
            Guid userId = loginUser.CreateUserId;
            if (ViewBag.IsAdmin)
            {
                userId = loginUser.UserId;
            }

            var list = _manager.GetGoodsList(userId, loginUser.TypeId, 1, 10, "", firstTypeId, "", "", "","");
            return Utils.SerializeObject(list);
        }


        public ActionResult Product(string fst = "", string sec = "", string trd = "", string brandId = "")
        {
            var fstType = _manager.GetGoodsType(fst);
            var secType = _manager.GetGoodsType(sec);
            var trdType = _manager.GetGoodsType(trd);
            var loginUser = (UserInfo)ViewBag.User;
            string para = "fst";
            Guid parentId = Guid.Empty;
            var TypeList = new List<GoodsType>();
            var BrandList = new List<GoodsBrand>();
            if (!string.IsNullOrWhiteSpace(trd))
            {
                para = "trd";
                parentId = Utils.ParseGuid(trd);
                secType = _manager.GetGoodsType(trdType.ParentId.ToString());
                fstType = _manager.GetGoodsType(secType.ParentId.ToString());
            }
            else if (!string.IsNullOrWhiteSpace(sec))
            {
                para = "trd";
                parentId = Utils.ParseGuid(sec);
                fstType = _manager.GetGoodsType(secType.ParentId.ToString());
            }
            else if (!string.IsNullOrWhiteSpace(fst))
            {
                para = "sec";
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
            return View();

        }

        public string LoadProductList(int page,int size, string fst = "", string sec = "", string trd = "", string brandId = "")
        {
            var loginUser = (UserInfo)ViewBag.User;
            Guid userId = loginUser.CreateUserId;
            if (ViewBag.IsAdmin)
            {
                userId = loginUser.UserId;
            }

            var list = _manager.GetGoodsList(userId, loginUser.TypeId, page,size, "", fst, sec, trd, brandId,"");
            return Utils.SerializeObject(list);
        }




        public ActionResult ProductDetail(Guid Id)
        {
            var product = _manager.GetGoodInfoById(Id);
            return View(product);
        }


        public string AddToShoppingCar(Guid goodId,int count)
        {
            bool res = false;
            var loginUser = (UserInfo)ViewBag.User;
            OrderItem basItem = new OrderItem();
            if (_order.IsExitInCar(goodId,loginUser.UserId, out basItem))
            {
                count += basItem.Count;
                res = _order.SaveOrderItem(basItem.Id, count);
            }
            else
            {
                var model = _manager.GetGoodsWithPrice(goodId, 1);
                OrderItem item = new OrderItem();
                item.Count = count;
                item.CreateUserId = loginUser.UserId;
                item.Id = Guid.NewGuid();
                item.LessPrice = 0;
                item.Price = model.price.Price;
                item.RealPrice = item.Price - item.LessPrice;
                item.ProductId = model.info.Id;
                item.ProductTittle = model.info.GoodsTittle;
                item.TotalPrice = item.RealPrice * count;
                item.ProductType = model.info.FirstTypeName;
                item.ProductTypeId = model.info.FirstTypeId;
                item.ProductId = model.info.Id;
                item.BarCode = model.info.BarCode;
                item.Spec = model.info.Spec;
                item.Unit = model.info.Unit;
                item.SupplierId = model.info.SupplierId;
                item.SupplierName = model.info.SupplierName;
                res = _order.AddOrderItem(item);
            }
            return Utils.SerializeObject(res);
        }


        public string LoadShoopingCarCount()
        {
            var loginUser = (UserInfo)ViewBag.User;
            var list = _order.GetShoppingCar(loginUser.UserId);
            return Utils.SerializeObject(list.Count);
        }




        public ActionResult ShoppingCar()
        {
            var loginUser = (UserInfo)ViewBag.User;
            var list = _order.GetShoppingCar(loginUser.UserId);
            ViewBag.List = list;
            return View();
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

        public void CreateOrder()
        {
            var loginUser = (UserInfo)ViewBag.User;
            var order = new OrderInfo();
            var saleMan = _user.GetUserByUserId(loginUser.SaleManGuid);
            order.Id = Guid.NewGuid();
            order.CreateTime = DateTime.Now;
            order.CreateUserId = loginUser.UserId;
            order.CreateUserName = loginUser.UserName;
            order.CreateUserType = loginUser.TypeName;
            order.CreateUserTypeId = loginUser.TypeId;
            order.RootUserId = loginUser.CreateUserId;
            order.RootUserName = loginUser.CreateUser;
            order.SaleManGuid = loginUser.SaleManGuid;
            order.SaleManName = loginUser.SaleManName;
            order.Province = loginUser.Province;
            order.ProvinceNum = loginUser.ProvinceNum;
            order.City = loginUser.City;
            order.CityNum = loginUser.CityNum;
            order.Area = loginUser.Area;
            order.AreaNum = loginUser.AreaNum;
            order.Stutas = (int)Common.Entities.OrderStatus.等待商家发货;
            order.SaleManTel = saleMan.Tel;
            var res = _order.SaveOrder(order);
            
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
    }
}