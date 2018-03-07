using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaleTools.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            InitPath(filterContext);
        }

        /// <summary>
        /// 初始化信息
        /// </summary>
        private void InitPath(ActionExecutingContext filterContext)
        {
            if (Session["LoginUser"] == null)
                filterContext.Result = new RedirectResult("/Login/Index", false);

            var user = (UserInfo)Session["LoginUser"];

            ViewBag.User = user;
            //当前登录用户的组织名称
        }
    }
}