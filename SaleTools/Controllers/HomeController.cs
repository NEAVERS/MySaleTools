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
            var user = (UserInfo)ViewBag.User;
            //TODO   传的Id要根据用户的类型（管理员传自己的用户Id 普通用户传创建人Id）
            var list = _manager.GetGoddsTypeTree(user.UserId);
            ViewBag.GoddsTypeTree = list;
            return View();
        }

        public string LoadProduct(string firstTypeId)
        {
            var loginUser = (UserInfo)Session["LoginUser"];
            var list = _manager.GetGoodsList(loginUser.CreateUserId, 1, 10, "", firstTypeId, "", "", "");
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
            }
            else if (!string.IsNullOrWhiteSpace(sec))
            {
                para = "trd";
                parentId = Utils.ParseGuid(sec);
            }
            else if (!string.IsNullOrWhiteSpace(fst))
            {
                para = "sec";
                parentId = Utils.ParseGuid(fst);
            }
            TypeList = _manager.GetDownGoodsType(parentId, loginUser.CreateUserId);
            if (para == "trd"&& !string.IsNullOrWhiteSpace(trd))
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
                    {model };
                }
            }
                ViewBag.TypeList = TypeList;
                ViewBag.BrandList = BrandList;
                ViewBag.Para = para;
            ViewBag.ParentGuid = parentId;
                return View();
            
        }

    }
}