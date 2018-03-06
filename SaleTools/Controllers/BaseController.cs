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
            var user = VerifyUtil.GetUserAccess();
            if (user.Org == null)
            {
                filterContext.Result = new RedirectResult("/verify.html?msg=" + HttpUtility.UrlEncode("您还没有机构信息，不能使用专业版"), false);
            }

            ViewBag.UserWithAccess = user;

            //当前登录用户的组织名称
            ViewBag.FastHttp = Helper.BaseConfigHelper.GetWebConfigByKey("FastImageUrl", true);
            ViewBag.LoginUserAccount = user.User.Account;
            ViewBag.LoginUserName = string.IsNullOrEmpty(user.User.Name) ? user.User.Account : user.User.Name;
            ViewBag.LoginUserTel = string.IsNullOrEmpty(user.User.Mobile) ? string.Empty : user.User.Mobile;
            ViewBag.LoginOrgName = user.Org.OrgName;
            ViewBag.LoginOrgId = user.Org.OrgGuid.ToString();
            ViewBag.SourceList = user.Resource;
            ViewBag.IsBankOrg = user.Org.RootOrgType == "银行";        //是否是银行类型 true是 false不是
        }
    }
}