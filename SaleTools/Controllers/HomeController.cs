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
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public string LoadProduct(string firstTypeId)
        {
            var loginUser = (UserInfo)Session["LoginUser"];
            Guid userId = loginUser.CreateUserId;
            if (ViewBag.IsAdmin)
            {
                userId = loginUser.UserId;
            }

            var list = _manager.GetGoodsList(userId, loginUser.TypeId, 1, 10, "", firstTypeId, "", "", "");
            return Utils.SerializeObject(list);
        }


        public ActionResult Product(string fst = "", string sec = "", string trd = "", string brandId = "")
        {
            var fstType = _manager.GetGoodsType(fst);
            var secType = _manager.GetGoodsType(sec);
            var trdType = _manager.GetGoodsType(trd);
            var loginUser = (UserInfo)Session["LoginUser"];
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
            return View();

        }



        public ActionResult ProductDetail(Guid Id)
        {
            var product = _manager.GetGoodInfoById(Id);
            return View(product);
        }

    }
}