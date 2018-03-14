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


        public ActionResult Product(string fst = "", string sec = "", string trd = "")
        {
            var fstType = _manager.GetGoodsType(fst);
            var secType = _manager.GetGoodsType(sec);
            var trdType = _manager.GetGoodsType(trd);
            var loginUser = (UserInfo)Session["LoginUser"];

            Guid parentId = Guid.Empty;
            var TypeList = new List<GoodsType>();
            if (!string.IsNullOrWhiteSpace(trd))
            {
                parentId = Utils.ParseGuid(trd);
            }
            else if(!string.IsNullOrWhiteSpace(sec))
            {
                parentId = Utils.ParseGuid(sec);
            }
            else if (!string.IsNullOrWhiteSpace(fst))
            {
                parentId = Utils.ParseGuid(fst);
            }
            TypeList = _manager.GetDownGoodsType(parentId, loginUser.CreateUserId);
            ViewBag.TypeList = TypeList;
            ViewBag.BrandList = _manager.GetBrandList(parentId);
            return View();
        }

    }
}