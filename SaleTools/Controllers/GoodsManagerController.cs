using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common;
using BLL;
using Model;
using Common.Entities;

namespace SaleTools.Controllers
{
    public class GoodsManagerController : BaseController
    {
        private GoodsManager _manager = new GoodsManager();
        private UserManager _user = new UserManager();
        // GET: GoodsManager
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 商品类型列表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult GoodsTypeList(string id = "")
        {
            if (Session["LoginUser"] == null)
                return RedirectToAction("Index", "Login");

            var loginUser = (UserInfo)Session["LoginUser"];
            var guid = Utils.ParseGuid(id);
            var type = _manager.GetTypeById(guid);
            var list = _manager.GetDownGoodsType(guid,loginUser.UserId);
            ViewBag.GoodsTypeList = list;
            ViewBag.TypeId = type!=null?type.ParentId.ToString():"";
            return View();
        }
        /// <summary>
        /// 根据上级Id获取商品类型Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetGoodsTypeList(string id ="" )
        {
            var loginUser = (UserInfo)Session["LoginUser"];
            var guid = Utils.ParseGuid(id);
            var list = _manager.GetDownGoodsType(guid, loginUser.UserId);
            return Utils.SerializeObject(list);
        }
        /// <summary>5
        /// 添加商品类型0
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="typeName"></param>
        /// <returns></returns>
        public string AddGoodType(Guid parent,string typeName)
        {
            var loginUser = (UserInfo)Session["LoginUser"];
            
            GoodsType type = new GoodsType();
            type.CreateUserId = loginUser.UserId;
            type.CreateUserName = loginUser.UserName;
            var parentModel = _manager.GetTypeById(parent);
            type.Id = Guid.NewGuid();
            type.TypeName = typeName;
            type.IsDelete = false;
            if (parentModel == null)
            {
                type.ParentId = Guid.Empty;
                type.ParentName = string.Empty;
            }
            else
            {
                type.ParentId = parentModel.Id;
                type.ParentName = parentModel.TypeName;
            }
            var res = _manager.AddGoodsType(type);
            return Utils.SerializeObject(res);
        }

        /// <summary>
        /// 删除商品类型
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public string DelGoodsType(Guid typeId)
        {
            var res = _manager.DelGoodsType(typeId);
            return Utils.SerializeObject(res);
        }

        /// <summary>
        /// 商品品牌页面
        /// </summary>
        /// <returns></returns>
        public ActionResult GoodsBrand()
        {
            var loginUser = (UserInfo)Session["LoginUser"];

            var goodList = _manager.GetAllBrand(loginUser.UserId);
            return View(goodList);
        }

        /// <summary>
        /// 添加商品品牌
        /// </summary>
        /// <param name="brandName"></param>
        /// <returns></returns>
        public string AddGoodBrand(string brandName)
        {
            var loginUser = (UserInfo)Session["LoginUser"];

            GoodsBrand brand = new GoodsBrand();
            brand.CreateUserId = loginUser.UserId;
            brand.CreateUserName = loginUser.UserName;
            brand.Id = Guid.NewGuid();
            brand.BrandName = brandName;
            brand.IsDelete = false;
            brand.Country = string.Empty;
            brand.Country = "中国";
           
            var res = _manager.AddGoodsBrand(brand);
            return Utils.SerializeObject(res);
        }

        /// <summary>
        /// 给某个商品类型添加商品品牌
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public ActionResult SetBrand(Guid typeId)
        {
            var loginUser = (UserInfo)Session["LoginUser"];
            ViewBag.TypeId = typeId;
            var typeList = _manager.GetBrandList(typeId);
            var brand = _manager.GetAllBrand(loginUser.UserId);
            ViewBag.TypeList = typeList;
            ViewBag.Brand = brand;
            return View();
        }

        /// <summary>
        /// 绑定品牌和商品类型
        /// </summary>
        /// <param name="typeId"></param>
        /// <param name="typeList"></param>
        /// <returns></returns>
        public string SaveBrandOfType(Guid typeId,List<Guid> typeList)
        {
            var res = _manager.SaveBrandOfType(typeId, typeList);
            return Utils.SerializeObject(res);
        }

        /// <summary>
        /// 添加商品页面
        /// </summary>
        /// <returns></returns>
        public ActionResult AddGoods(string id ="")
        {
            Guid goodId = Utils.ParseGuid(id);
            var info = new GoodInfo();
            var pirceList = new List<PriceOfUserType>();

            if (goodId != Guid.Empty)
            {
                pirceList = _manager.GetPriceOfUserTypeByGoodsId(goodId);
                info = _manager.GetGoodInfoById(goodId);
            }
            var loginUser = (UserInfo)Session["LoginUser"];
            var list = _user.GetTypeList();
            var supplierList = _user.GetSupplierList(loginUser.UserId);
            ViewBag.SupplierList = supplierList;
            ViewBag.UserTypeList = list;
            ViewBag.PriceList = pirceList;
            return View(info);
        }

        /// <summary>
        /// 获取品牌列表
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public string GetBrandList(Guid typeId)
        {
            var typeList = _manager.GetBrandList(typeId);
            return Utils.SerializeObject(typeList);
        }

        /// <summary>
        /// 保存商品
        /// </summary>
        /// <param name="goods"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        public string SaveGoods(GoodInfo goods ,List<string> price)
        {
            var loginUser = (UserInfo)Session["LoginUser"];
            bool res = false;
            goods.LastUpdateTime = DateTime.Now;
            if (goods.Id == Guid.Empty)
            {
                goods.Id = Guid.NewGuid();
                goods.CreateUserId = loginUser.UserId;
                goods.CreateUserName = loginUser.UserName;
                goods.CreateTime = DateTime.Now;
            }
            res = _manager.UpdateGoodsInfo(goods);
            if (res)
            {
                List<PriceOfUserType> priceList = new List<PriceOfUserType>();
                price.ForEach(x =>
                {
                    var a = x.Split(',');
                    int typeId = Utils.ParseInt(a[0]);
                    decimal _price = Utils.ParseDecimal(a[1]);
                    if (_price > 0)
                    {
                        var model = new PriceOfUserType();
                        model.CreateTime = DateTime.Now;
                        model.Price = _price;
                        model.GoodsId = goods.Id;
                        model.UserTypeId = typeId;
                        priceList.Add(model);
                    }
                });
                res = _manager.SavePrice(priceList);
            }

            return res.ToString();
        }




        public ActionResult GoodsList()
        {
            var loginUser = (UserInfo)Session["LoginUser"];
            var list = _user.GetTypeList();

            var supplierList = _user.GetSupplierList(loginUser.UserId);
            ViewBag.SupplierList = supplierList;
            ViewBag.UserTypeList = list;

            return View();
        }

        /// <summary>
        /// 获取商品列表
        /// </summary>
        /// <param name="index"></param>
        /// <param name="size"></param>
        /// <param name="SupplierId"></param>
        /// <param name="fstTypeId"></param>
        /// <param name="secTypeId"></param>
        /// <param name="thdTypeId"></param>
        /// <param name="keyWord"></param>
        /// <returns></returns>
        public string GetGoodsList(int index,int size,string SupplierId = "",string fstTypeId = "",string secTypeId="",string thdTypeId = "",string keyWord="")
        {
            var loginUser = (UserInfo)Session["LoginUser"];
            Guid userId = loginUser.CreateUserId;
            if(ViewBag.IsAdmin)
            {
                userId = loginUser.UserId;
            }
            var page = _manager.GetGoodsList(userId, loginUser.TypeId, index, size, SupplierId, fstTypeId, secTypeId, thdTypeId, "",keyWord);
            return Utils.SerializeObject(page);
        }
        /// <summary>
        /// 删除商品
        /// </summary>
        /// <param name="goodsIds"></param>
        /// <returns></returns>
        public string DeleteGoods(List<Guid> goodsIds)
        {
            var res = _manager.Delete(goodsIds);
            return Utils.SerializeObject(res);
        }

        /// <summary>
        /// 更改商品上架状态
        /// </summary>
        /// <param name="goodsIds"></param>
        /// <param name="isShelves"></param>
        /// <returns></returns>
        public string ToggleShelves(List<Guid> goodsIds,bool isShelves)
        {
            var res = _manager.ToggleShelves(goodsIds, isShelves);
            return Utils.SerializeObject(res);
        }



    }
}