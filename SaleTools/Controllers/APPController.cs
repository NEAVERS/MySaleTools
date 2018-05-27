using BLL;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace SaleTools.Controllers
{
    public class APPController : Controller
    {
        // GET: APP
        private UserManager _manager = new UserManager();

        public string Login(string userName,string pwd)
        {
            pwd = Utils.GetMD5(pwd);
            var ip = Utils.GetUserHostAddress();
            var user = _manager.Login(userName, pwd, ip);
            bool result = false;
            if (user != null)
            {
                HttpCookie cookie = new HttpCookie("UserId");
                cookie.Value = user.UserId.ToString();
                cookie.Expires = DateTime.Now.AddDays(7);
                Response.Cookies.Add(cookie);
                result = true;
            }
            return "jsoncallback("+ Utils.SerializeObject(result)+")";
        }


    }
}