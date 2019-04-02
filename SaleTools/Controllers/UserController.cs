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
        private SystemManager _system = new SystemManager();
        private ResponseModel _response = new ResponseModel();
        // GET: Usei
        public ActionResult Index()
        {
            var loginUser = (UserInfo)ViewBag.User;

            if (loginUser.TypeId >1)
            {
                return RedirectToAction("NoResourse", "System");
            }
            var typelist = manager.GetTypeList();
            ViewBag.TypeList = typelist;

            var list = manager.GetSysUser((int)SystemUserType.业务员, loginUser.CreateUserId);
            ViewBag.SaleManList = list;
            return View();
        }

        public string SetSaleMan(Guid userId, Guid saleManId, string saleManName)
        {
            var res = manager.SetSaleMan(userId, saleManId, saleManName);
            return Utils.SerializeObject(res);
        }
        public ActionResult AddNewUser()
        {
            var Resourse = (List<string>)ViewBag.Resourse;
            if (Resourse.Contains(ResourceStr.StoreManager) || Resourse.Contains(ResourceStr.SuperAdmin))
            {

                var loginUser = (UserInfo)ViewBag.User;
                var list = manager.GetTypeList();
                ViewBag.TypeList = list;
                var saleList = manager.GetSysUser((int)SystemUserType.业务员, loginUser.CreateUserId);
                ViewBag.SaleManList = saleList;

                return View();
            }
            else
            {
                return RedirectToAction("NoResourse", "System");
            }
        }

  


        public string GetList(int index , int size , string  start, string end,string province,string city,string area,string saleManId, int userType, string  key = "")
        {
            var startTime = DateTime.MinValue;
            var endTime = DateTime.MaxValue;
            var list = manager.GetUserByPage(index, size, startTime, endTime,  province,  city,  area,  saleManId,  userType, key.Trim(), false);

            return Utils.SerializeObject(list);
        }



        public ActionResult ExportUserInfo(string start, string end, string province, string city, string area, string saleManId, int userType, string key = "")
        {
            var startTime = DateTime.MinValue;
            var endTime = DateTime.MaxValue;
            var output = manager.ExportUserInfo(startTime, endTime, province, city, area, saleManId, userType, key, false);
             return File(output, "text/comma-separated-values", Guid.NewGuid().ToString("N") + ".csv");
        }



        public string ToggaleLock(Guid userId)
        {
            var res = manager.ToggaleLock(userId);
            return Utils.SerializeObject(res);
        }

        public string SaveUser(UserInfo user)
        {
            List<string> Resourses = new List<string>();
            var loginUser =  (UserInfo)ViewBag.User;;
            if(!string.IsNullOrWhiteSpace(user.PassWord))
                user.PassWord = Utils.GetMD5(user.PassWord);
            bool res = false;
            if(!manager.CheckPhone(user.UserId, user.Tel))
            {
                _response.Msg = "该电话已存在！请重新填写！";
                return Utils.SerializeObject(_response);
            }
            if (!manager.CheckUsernum(user.UserId, user.UserNum))
            {
                _response.Msg = "该用户编号已存在！请重新填写！";
                return Utils.SerializeObject(_response);
            }

            if (!manager.CheckAccount(user.UserId, user.Account))
            { 
                _response.Msg = "该账号已存在！请重新填写！";
                return Utils.SerializeObject(_response);
            }
            if (manager.IsExitUser(user.UserId))
            {
                if (user.TypeId > 0)
                {
                    Resourses.Add(ResourceStr.ShowMyOrder);
                    Resourses.Add(ResourceStr.ChangePwd);
                    Resourses.Add(ResourceStr.ShowMyCoupon);
                    Resourses.Add(ResourceStr.ShowAccountInfo);
                }
                user.CreateUser = loginUser.UserName;
                user.CreateUserId = loginUser.UserId;
                user.UserId = Guid.NewGuid();
                _response.Stutas = manager.UserReg(user);
            }
            else
                _response.Stutas = manager.UpdateUser(user);
            if (_response.Stutas)
            {
                _response.Stutas = manager.SaveUserResourse(user.UserId, Resourses);
            }
            return Utils.SerializeObject(_response);

        }

        public string SaveSysUser(UserInfo user,List<string> Resourses)
        {
            var loginUser =  (UserInfo)ViewBag.User;;
            if(!string.IsNullOrWhiteSpace(user.PassWord))
                user.PassWord = Utils.GetMD5(user.PassWord);
            bool res =  false;
            if (user.TypeId > 0)
                Resourses.Add(ResourceStr.ShowMyOrder);
            if (user.UserId == Guid.Empty)
            {
                user.CreateUser = loginUser.UserName;
                user.CreateUserId = loginUser.UserId;
                user.UserId = Guid.NewGuid();
                res = manager.UserReg(user);
            }
            else
                res = manager.UpdateUser(user);
            if(res)
            {
                res = manager.SaveUserResourse(user.UserId, Resourses);
            }
            return Utils.SerializeObject(res);
            
        }
        public string DelUser(Guid userId)
        {
            var res = manager.DelUser(userId);
            return Utils.SerializeObject(res);
        }


     

        public ActionResult ShowSupplierList()
        {

            var loginUser =  (UserInfo)ViewBag.User;;
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

            var loginUser =  (UserInfo)ViewBag.User;;

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

            var Resourse = (List<string>)ViewBag.Resourse;
            if (Resourse.Contains(ResourceStr.StoreManager) || Resourse.Contains(ResourceStr.SuperAdmin))
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
            else
            {
                return RedirectToAction("NoResourse", "System");
            }
        }


        public ActionResult AddSysAccount(int type, string userId = "")
        {
            var userGuid = Utils.ParseGuid(userId);
            var user = manager.GetUserByUserAndType(userGuid, type);
            Guid managerId = (Guid)ViewBag.ManagerId;
            string modelName = "编辑";
            if (user == null)
            {
                user = new UserInfo();
                modelName = "新增";
            }
            var userResourse = manager.GetUserSourse(user.UserId);
            string userTypeName = ((SystemUserType)type).ToString();
            modelName += userTypeName ;
            ViewBag.UserTypeName = userTypeName;
            ViewBag.UserType = type;
            ViewBag.AllResourse = manager.GetAllSourse();
            ViewBag.UserResourse = userResourse;
            ViewBag.ModelName = modelName;
            return View(user);
        }


        public ActionResult SysAccount(int type)
        {
            var loginUser = (UserInfo)ViewBag.User;
            string userTypeName = ((SystemUserType)type).ToString();
            ViewBag.UserTypeName = userTypeName;
            ViewBag.UserType = type;
            Guid managerId = (Guid)ViewBag.ManagerId;
            var list = manager.GetSysUser(type, managerId);
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

        public string CheckNumIsExit(string num)
        {
            var res = manager.IsExitNum(num);
            return Utils.SerializeObject(res);
        }

        public ActionResult MyInfo()
        {
            var loginUser = (UserInfo)ViewBag.User;
            return View(loginUser);
        }

    }
}