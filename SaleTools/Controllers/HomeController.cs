using BLL;
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
    }
}