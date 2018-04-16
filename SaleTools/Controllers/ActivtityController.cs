﻿using BLL;
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

    public class ActivtityController : BaseController
    {
        private ActiveManager _active = new ActiveManager();
        private UserManager _user = new UserManager();
        ResponseModel _response = new ResponseModel();
        private GoodsManager _good = new GoodsManager();
        // GET: Activtity
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowCoupon(int index =1,string start = "",string end = "",int stutas = -1,string storeNum="")
        {
            var loginUser = (UserInfo)ViewBag.User;
            DateTime startTime = new DateTime();
            DateTime endTime = new DateTime();
            DateTime now = DateTime.Now;
            if (string.IsNullOrEmpty(start))
                startTime = new DateTime(now.Year, now.Month, now.Day - 1, 16, 0, 0);
            else
                startTime = Utils.GetTime(start, true);
            if (string.IsNullOrEmpty(end))
                endTime = new DateTime(now.Year, now.Month, now.Day, 16, 0, 0);
            else
                endTime = Utils.GetTime(end);
            var page = _active.GetCouponPager(index, startTime, endTime, stutas, storeNum, loginUser.UserId);

            ViewBag.Start = startTime;
            ViewBag.End = endTime;
            ViewBag.Stutas = stutas;
            ViewBag.StoreNum = storeNum;
            ViewBag.Pager = page;
            return View();
        }

        public ActionResult AddNewCoupon()
        {
            var loginUser = (UserInfo)ViewBag.User;

            var typelist = _user.GetTypeList();
            var suppliers = _user.GetSupplierList(loginUser.UserId);
            var BrandList = _good.GetAllBrand(loginUser.UserId);

            ViewBag.TypeList = typelist;
            ViewBag.Supplier = suppliers;
            ViewBag.BrandList = BrandList;
            return View(); 
        }

        public ActionResult SaveCoupon(Coupon c,string number, List<int> userType,int addtype)
        {
            var loginUser = (UserInfo)ViewBag.User;
            var userList = new List<UserInfo>();

            if (addtype == 0)
            {
                var userNums = number.Split(',').ToList();
                userList = _user.GetUserInfByNunm(userNums, loginUser.UserId);
            }
            else
            {
                userList = _user.GetUserInfoByUserType(userType, loginUser.UserId);
            }
            c.CreateTime = DateTime.Now;
            c.CreateUserId = loginUser.UserId;
            c.CreateUserName = loginUser.UserName;

            _active.CreateCoupon(c, userList);
            Response.Redirect("ShowCoupon");
            return View();
        }


        public ActionResult AddNewManSong()
        {
            var loginUser = (UserInfo)ViewBag.User;

            var typelist = _user.GetTypeList();
            var suppliers = _user.GetSupplierList(loginUser.UserId);
            var BrandList = _good.GetAllBrand(loginUser.UserId);

            ViewBag.TypeList = typelist;
            ViewBag.Supplier = suppliers;
            ViewBag.BrandList = BrandList;
            return View();
        }

        public void SaveManSong(Manjiusong m, List<int> userType,string areaNums)
        {

            var areaList = areaNums.Split(',').ToList();
            var loginUser = (UserInfo)ViewBag.User;

            m.CreateTime = DateTime.Now;
            m.CreateUserId = loginUser.UserId;
            string userTypes = "";
            userType.ForEach(x =>
            {
                userTypes += x;
                userTypes += ",";
            });
            m.UserTypes = userTypes;
            _active.CreateManjiusong(m, areaList);
        }


        public ActionResult AddNewManJian()
        {
            var loginUser = (UserInfo)ViewBag.User;

            var typelist = _user.GetTypeList();
            var suppliers = _user.GetSupplierList(loginUser.UserId);
            var BrandList = _good.GetAllBrand(loginUser.UserId);

            ViewBag.TypeList = typelist;
            ViewBag.Supplier = suppliers;
            ViewBag.BrandList = BrandList;
            return View();
        }
        public void SaveManJian(Manjiujian m, List<int> userType, string areaNums)
        {
            var loginUser = (UserInfo)ViewBag.User;
            var areaList = areaNums.Split(',').ToList();

            m.CreateTime = DateTime.Now;
            m.CreateUserId = loginUser.UserId;
            string userTypes = "";
            userType.ForEach(x =>
            {
                userTypes += x;
                userTypes += ",";
            });
            m.UserTypes = userTypes;
            _active.CreateManjiujian(m, areaList);
        }

        public string CheckGoods(string num)
        {
            var loginUser = (UserInfo)ViewBag.User;

            var res = _good.GetGoodsByNum(num, loginUser.UserId);
            _response.Result = res;
            if (res != null)
                _response.Stutas = true;
            return Utils.SerializeObject(_response);
        }

        public ActionResult GetManSongList(int index = 1)
        {
            var loginUser = (UserInfo)ViewBag.User;
            var pager= _active.GetManSongPager(loginUser.UserId, index);
            ViewBag.Pager = pager;
            return View();
        }

        public ActionResult GetManJianList(int index = 1)
        {
            var loginUser = (UserInfo)ViewBag.User;
            var pager = _active.GetManSongPager(loginUser.UserId, index);
            ViewBag.Pager = pager;
            return View();
        }


        public ActionResult EditManSong(Guid activeId)
        {
            var detail = _active.GetManSongDetial(activeId);
            var loginUser = (UserInfo)ViewBag.User;

            var typelist = _user.GetTypeList();
            var suppliers = _user.GetSupplierList(loginUser.UserId);
            var BrandList = _good.GetAllBrand(loginUser.UserId);
            var areas = detail.areas.Select(x => x.Num + "_" + x.Name).ToArray();
            ViewBag.AreaJson = Utils.SerializeObject(areas);

            ViewBag.TypeList = typelist;
            ViewBag.Supplier = suppliers;
            ViewBag.BrandList = BrandList;

            return View(detail);
        }

        public ActionResult SaveEditManSong(Manjiusong m, List<int> userType, string areaNums)
        {
            var areaList = areaNums.Split(',').ToList();
            var loginUser = (UserInfo)ViewBag.User;

            m.CreateTime = DateTime.Now;
            m.CreateUserId = loginUser.UserId;
            string userTypes = "";
            userType.ForEach(x =>
            {
                userTypes += x;
                userTypes += ",";
            });
            m.UserTypes = userTypes;
            _active.SaveManjiusong(m, areaList);
            Response.Redirect("GetManSongList");
            return View();
        }



        public ActionResult EditManJian(Guid activeId)
        {
            var detail = _active.GetManSongDetial(activeId);
            var loginUser = (UserInfo)ViewBag.User;

            var typelist = _user.GetTypeList();
            var suppliers = _user.GetSupplierList(loginUser.UserId);
            var BrandList = _good.GetAllBrand(loginUser.UserId);
            var areas = detail.areas.Select(x => x.Num + "_" + x.Name).ToArray();
            ViewBag.AreaJson = Utils.SerializeObject(areas);

            ViewBag.TypeList = typelist;
            ViewBag.Supplier = suppliers;
            ViewBag.BrandList = BrandList;

            return View(detail);
        }

        public ActionResult SaveEditManJian(Manjiujian m, List<int> userType, string areaNums)
        {
            var areaList = areaNums.Split(',').ToList();
            var loginUser = (UserInfo)ViewBag.User;

            m.CreateTime = DateTime.Now;
            m.CreateUserId = loginUser.UserId;
            string userTypes = "";
            userType.ForEach(x =>
            {
                userTypes += x;
                userTypes += ",";
            });
            m.UserTypes = userTypes;
            _active.SaveManjiujian(m, areaList);
            Response.Redirect("GetManJianList");
            return View();
        }

    }
}