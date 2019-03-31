using BLL;
using Common.Entities;
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
        private GoodsManager _manager = new GoodsManager();
        private UserManager _user = new UserManager();

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            InitPath(filterContext);
        }

        /// <summary>
        /// 初始化信息
        /// </summary>
        private void InitPath(ActionExecutingContext filterContext)
        {
            if (Request.Cookies["UserId"] == null)
            {
                filterContext.Result = new RedirectResult("/Login/Index", false);
                return;
            }
            
            Guid id = new Guid();
            if (!Guid.TryParse(Request.Cookies["UserId"].Value, out id))
            {
                id = Guid.Empty;
                filterContext.Result = new RedirectResult("/Login/Index", false);
                return;
            }

            var user = _user.GetUserByUserId(id);
            if (user==null)
            {
                filterContext.Result = new RedirectResult("/Login/Index", false);
                return;
            }
            //TODO   传的Id要根据用户的类型（管理员传自己的用户Id 普通用户传创建人Id）
            if (user != null)
            {
                
                var isAdmin = user.TypeId == (int)SystemUserType.系统管理员;
                ViewBag.IsAdmin = isAdmin;
                Guid userid = user.CreateUserId;
                var resourse = _user.GetUserSourse(user.UserId);
                if (isAdmin)
                {
                    userid = user.UserId;
                    if (resourse == null)
                        resourse = new List<string>();
                    resourse.Add(ResourceStr.SuperAdmin);
                }
                
                var list = _manager.GetGoddsTypeTree(userid);
                ViewBag.GoddsTypeTree = list;
                ViewBag.User = user;
                ViewBag.UserName = user.UserName;
                ViewBag.Resourse = resourse;
                ViewBag.ManagerId = userid;


            }
            //当前登录用户的组织名称
        }
    }
}