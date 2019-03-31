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
    public class LoginController : Controller
    {
        private UserManager _manager = new UserManager();
        // GET: Login
        public ActionResult Index()
        {
        
            return View();
        }

        public string  AccountLogin(string account,string Pwd)
        {
            Pwd = Utils.GetMD5(Pwd);
            var ip = Utils.GetUserHostAddress();
            var user = _manager.Login(account, Pwd, ip);
            if (user == null)
                return "登陆失败";
            //锁定后不能进行登陆
            if (user.IsLocked == true)
                return "该账号已被锁定！请联系管理员解除锁定后登陆";
            else
            {
                HttpCookie cookie = new HttpCookie("UserId");
                cookie.Value = user.UserId.ToString();
                cookie.Expires = DateTime.Now.AddDays(7);
                Response.Cookies.Add(cookie);
                return "登陆成功";
            }

        }

        public ActionResult AddAdmin()
        {
            UserInfo user = new UserInfo();
            user.Account = "admin";
            user.PassWord = Utils.GetMD5("123456");
            user.UserId = Guid.NewGuid();
            user.CreateUserId = user.UserId;
            user.UserNum = "admin";
            user.CreateTime = DateTime.Now;
            _manager.UserReg(user);
            return View();
        }


        public ActionResult LogOut()
        {
            HttpCookie hc = Request.Cookies["UserId"];
            hc.Expires = DateTime.Now.AddDays(-1);
            Response.AppendCookie(hc);
            return View("Index");
        }

    }
}