using BLL;
using Common;
using Common.Entities;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaleTools.Controllers
{
    public class UserController : BaseController
    {
        private UserManager manager = new UserManager();
        // GET: Usei
        public ActionResult Index()
        {
            var typelist = manager.GetTypeList();
            ViewBag.TypeList = typelist;

            var loginUser = (UserInfo)ViewBag.User;
            var list = manager.GetSysUser((int)SystemUserType.业务员, loginUser.CreateUserId);
            ViewBag.SaleManList = list;
            return View();
        }

        public string SetSaleMan(Guid userId, Guid saleManId,string saleManName)
        {
            var res = manager.SetSaleMan(userId, saleManId, saleManName);
            return Utils.SerializeObject(res);
        }

        public ActionResult AddNewUser()
        {
            var loginUser = (UserInfo)ViewBag.User;
            var list = manager.GetTypeList();
            ViewBag.TypeList = list;
            var saleList = manager.GetSysUser((int)SystemUserType.业务员, loginUser.CreateUserId);
            ViewBag.SaleManList = saleList;

            return View();
        }

        public ActionResult UserTyoeList()
        {
            var list = manager.GetTypeList(true);
            return View(list);
        }



        public string GetList(int index , int size , string  start, string end,string province,string city,string area,string saleManId, int userType, string  key = "")
        {
            var startTime = Utils.GetTime(start, true);
            var endTime = Utils.GetTime(end);
            var list = manager.GetUserByPage(index, size, startTime, endTime,  province,  city,  area,  saleManId,  userType, key, false);

            return Utils.SerializeObject(list);
        }


        public string ToggaleLock(Guid userId)
        {
            var res = manager.ToggaleLock(userId);
            return Utils.SerializeObject(res);
        }


        public  string SaveUser(UserInfo user)
        {
            var loginUser = (UserInfo)Session["LoginUser"];
            user.PassWord = Utils.GetMD5(user.PassWord);
            bool res =  false;
            if (user.UserId == Guid.Empty)
            {
                user.CreateUser = loginUser.UserName;
                user.CreateUserId = loginUser.UserId;
                user.UserId = Guid.NewGuid();
                res = manager.UserReg(user);
            }
            else
                res = manager.UpdateUser(user);
            return Utils.SerializeObject(res);
            
        }
        public string DelUser(Guid userId)
        {
            var res = manager.DelUser(userId);
            return Utils.SerializeObject(res);
        }


        public string AddUserType(string userType,bool isAdmin)
        {
            var res = manager.AddUserType(userType, isAdmin);
            return res;
        }

        public ActionResult ShowSupplierList()
        {
            if(Session["LoginUser"] == null)
                return RedirectToAction("Index", "Login");
            var loginUser = (UserInfo)Session["LoginUser"];
            var list = manager.GetSupplierList(loginUser.UserId);
            return View(list);
        }

        public ActionResult SupplierDeltie(int id = 0)
        {
            var model = new Supplier();
            if (id > 0)
                model = manager.GetSupplierById(id);
            return View(model);
        }
        public string DeleteSupplier(int id)
        {
            var result = manager.DelSupplier(id);
            return Utils.SerializeObject(result);
        }

        public ActionResult AddOrUpdateSupplier(Supplier model)
        {
            if (Session["LoginUser"] == null)
                return RedirectToAction("Index", "Login");
            var loginUser = (UserInfo)Session["LoginUser"];

            if (model.Id == 0)
            {
                model.CreateUserId = loginUser.UserId;
                model.CreateUserName = loginUser.UserName;
                manager.AddSupplier(model);
            }
            else
            {
                manager.UpdateSupplier(model);
            }
            return RedirectToAction("ShowSupplierList", "User");

        }

        public ActionResult EditUserInfo(Guid id)
        {
            var loginUser = (UserInfo)ViewBag.User;

            var list = manager.GetTypeList();
            ViewBag.TypeList = list;

            var model = manager.GetUserByUserId(id);
            var saleList = manager.GetSysUser((int)SystemUserType.业务员, loginUser.CreateUserId);
            ViewBag.SaleManList = saleList;

            if (model == null)
                return RedirectToAction("AddNewUser", "User");
            else return View(model);
        }    
        

        public ActionResult AddSysAccount(int type)
        {
            string userTypeName = ((SystemUserType)type).ToString();
            ViewBag.UserTypeName = userTypeName;
            ViewBag.UserType = type;
            return View();
        }


        public ActionResult SysAccount(int type)
        {
            var loginUser = (UserInfo)ViewBag.User;
            string userTypeName = ((SystemUserType)type).ToString();
            ViewBag.UserTypeName = userTypeName;
            ViewBag.UserType = type;

            var list = manager.GetSysUser(type,loginUser.UserId);
            ViewBag.List = list;
            return View();
        }
     
        public ActionResult ChangePwd()
        {
            return View();
        }

        public string SaveNewPwd(string oldPwd, string newPwd)
        {
            var loginUser = (UserInfo)ViewBag.User;
            string oldMd5 = Utils.GetMD5(oldPwd);
            string newMd5 = Utils.GetMD5(newPwd);
            var result = manager.ChangePwd(loginUser.UserId, oldMd5, newMd5);
            return Utils.SerializeObject(result);
        }
    }
}