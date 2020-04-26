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


            Guid managerId = (Guid)ViewBag.ManagerId;

            var guid = Utils.ParseGuid(id);
            var type = _manager.GetTypeById(guid);
            var list = _manager.GetDownGoodsType(guid, managerId);
            ViewBag.GoodsTypeList = list;
            ViewBag.ParentId = type != null ? type.ParentId.ToString() : "";
            ViewBag.TypeId = guid;
            return View();
        }
        /// <summary>
        /// 根据上级Id获取商品类型Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetGoodsTypeList(string id ="" )
        {
            Guid managerId = (Guid)ViewBag.ManagerId;
            var guid = Utils.ParseGuid(id);
            var list = _manager.GetDownGoodsType(guid, managerId);
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
            var loginUser =  (UserInfo)ViewBag.User;;
            Guid managerId = (Guid)ViewBag.ManagerId;
            GoodsType type = new GoodsType();
            type.CreateUserId = managerId;
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
            Guid managerId = (Guid)ViewBag.ManagerId;

            var goodList = _manager.GetAllBrand(managerId);
            return View(goodList);
        }

        /// <summary>
        /// 添加商品品牌
        /// </summary>
        /// <param name="brandName"></param>
        /// <returns></returns>
        public string AddGoodBrand(string brandName)
        {
            var loginUser =  (UserInfo)ViewBag.User;;
            Guid managerId = (Guid)ViewBag.ManagerId;

            GoodsBrand brand = new GoodsBrand();
            brand.CreateUserId = managerId;
            brand.CreateUserName = loginUser.UserName;
            brand.Id = Guid.NewGuid();
            brand.BrandName = brandName;
            brand.IsDelete = false;
            brand.Country = string.Empty;
            brand.Country = "中国";
           
            var res = _manager.AddGoodsBrand(brand);
            return Utils.SerializeObject(res);
        }


        public string DeleteGoodBrand(List<string> brandsId)
        {
            var res = _manager.DeleteGoodsBrands(brandsId);
            return Utils.SerializeObject(res);
        }


        /// <summary>
        /// 给某个商品类型添加商品品牌
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public ActionResult SetBrand(Guid typeId)
        {
            Guid managerId = (Guid)ViewBag.ManagerId;
            ViewBag.TypeId = typeId;
            var typeList = _manager.GetBrandList(typeId);
            var brand = _manager.GetAllBrand(managerId);
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
            var Resourse = (List<string>)ViewBag.Resourse;
            if (Resourse.Contains(ResourceStr.GoodsManager) || Resourse.Contains(ResourceStr.SuperAdmin))
            {
                Guid goodId = Utils.ParseGuid(id);
                var info = new GoodInfo();
                ViewBag.ShowTittle = "新增商品";
                if (goodId != Guid.Empty)
                {
                    ViewBag.ShowTittle = "编辑商品信息";
                    info = _manager.GetGoodInfoById(goodId);
                }
                Guid managerId = (Guid)ViewBag.ManagerId;
                var list = _user.GetTypeList();
                var supplierList = _user.GetSupplierList(managerId);
                ViewBag.SupplierList = supplierList;
                ViewBag.UserTypeList = list;
                return View(info);
            }
            else
            {
                return RedirectToAction("NoResourse", "System");
            }
        }

        public ActionResult ShowGoodsInfo(Guid goodId)
        {
            var info = _manager.GetGoodInfoById(goodId);
            var loginUser =  (UserInfo)ViewBag.User;;
            Guid managerId = (Guid)ViewBag.ManagerId;
            var list = _user.GetTypeList();
            var supplierList = _user.GetSupplierList(managerId);
            ViewBag.SupplierList = supplierList;
            ViewBag.UserTypeList = list;
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
            var loginUser =  (UserInfo)ViewBag.User;;
            Guid managerId = (Guid)ViewBag.ManagerId;
            bool res = false;
            goods.LastUpdateTime = DateTime.Now;
            if (goods.Id == Guid.Empty)
            {
                goods.Id = Guid.NewGuid();
                goods.CreateUserId = managerId;
                goods.CreateUserName = loginUser.UserName;
                goods.CreateTime = DateTime.Now;
            }
            string erpId = _manager.GetErpId(goods.GoodsNum);
            goods.ErpId = erpId;
            res = _manager.UpdateGoodsInfo(goods);

            return res.ToString();
        }




        public ActionResult GoodsList()
        {
            Guid managerId = (Guid)ViewBag.ManagerId;
            var list = _user.GetTypeList();

            var supplierList = _user.GetSupplierList(managerId);
            ViewBag.SupplierList = supplierList;
            ViewBag.UserTypeList = list;
            return View();
        }

        public string UpdateSortId(Guid goodsId,int sortId)
        {
            var res = _manager.UpdateSortId(goodsId, sortId);
            return Utils.SerializeObject(res);
        }
        public string UpdateMinCount(Guid goodsId, int minCount)
        {
            var res = _manager.UpdateMinCount(goodsId, minCount);
            return Utils.SerializeObject(res);
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
        public string GetGoodsList(int index,int size,string SupplierId = "",string fstTypeId = "",string secTypeId="",string thdTypeId = "",string keyWord="",string IsUpShelves="",string sort= "",string order = "Asc")
        {
            var loginUser =  (UserInfo)ViewBag.User;;
            var page = _manager.GetGoodsListByManager(ViewBag.ManagerId, loginUser.TypeId, index, size, SupplierId, fstTypeId, secTypeId, thdTypeId, "",keyWord.Trim(), IsUpShelves,sort,order);
            return Utils.SerializeObject(page);
        }


        public ActionResult ExportGoodInfo(string SupplierId = "", string fstTypeId = "", string secTypeId = "", string thdTypeId = "", string keyWord = "")
        {
            var loginUser =  (UserInfo)ViewBag.User;;
            PageData<GoodInfo> page = _manager.GetGoodsList(ViewBag.ManagerId, loginUser.TypeId, 1, 100000, SupplierId, fstTypeId, secTypeId, thdTypeId, "", keyWord, "");
            var output = _manager.ExportGoodInfo(page.ListData);
            return File(output, "application/ms-excel", "商品列表.xlsx");
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

        public ActionResult CopyNew(Guid Id)
        {
            var Resourse = (List<string>)ViewBag.Resourse;
            if (Resourse.Contains(ResourceStr.GoodsManager) || Resourse.Contains(ResourceStr.SuperAdmin))
            {
              
                var info = new GoodInfo();
                info = _manager.GetGoodInfoById(Id);
                var loginUser =  (UserInfo)ViewBag.User;;
                Guid managerId = (Guid)ViewBag.ManagerId;
                var list = _user.GetTypeList();
                var supplierList = _user.GetSupplierList(managerId);
                ViewBag.SupplierList = supplierList;
                ViewBag.UserTypeList = list;
                info.Id = Guid.Empty;
                ViewBag.ShowTittle = "复制新增商品";
                return View("AddGoods",info);
            }
            else
            {
                return RedirectToAction("NoResourse", "System");
            }
           
        }


       


    }
}