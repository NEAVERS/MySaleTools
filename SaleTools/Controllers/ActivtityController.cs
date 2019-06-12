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

        /// <summary>
        /// 优惠券列表
        /// </summary>
        /// <param name="index"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="stutas"></param>
        /// <param name="storeNum"></param>
        /// <returns></returns>
        public ActionResult ShowCoupon(int index = 1, string start = "", string end = "", int stutas = -1, string storeNum = "")
        {
            var loginUser = (UserInfo)ViewBag.User;
            DateTime startTime = new DateTime();
            DateTime endTime = new DateTime();
            DateTime now = DateTime.Now;
            DateTime date = now.AddDays(-1);
            if (string.IsNullOrEmpty(start))
                startTime = new DateTime(date.Year, date.Month, date.Day - 1, 16, 0, 0);
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
        /// <summary>
        /// 添加优惠券
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// 保存优惠券
        /// </summary>
        /// <param name="c"></param>
        /// <param name="number"></param>
        /// <param name="userType"></param>
        /// <param name="addtype"></param>
        /// <returns></returns>
        public ActionResult SaveCoupon(Coupon c, string number, List<int> userType, int addtype)
        {
            var loginUser = (UserInfo)ViewBag.User;
            var userList = new List<UserInfo>();
            Guid managerId = (Guid)ViewBag.ManagerId;
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
            c.CreateUserId = managerId;
            c.CreateUserName = loginUser.UserName;

            _active.CreateCoupon(c, userList);
            Response.Redirect("ShowCoupon");
            return View();
        }
        /// <summary>
        /// 修改优惠券过期时间
        /// </summary>
        /// <param name="id"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public string UpdateCouponEndTime(Guid id, DateTime endTime)
        {
            var res = _active.UpdateCouponEndTime(id, endTime);
            return Utils.SerializeObject(res);
        }

        public ActionResult AddNewManSong()
        {
            var loginUser = (UserInfo)ViewBag.User;
            Guid managerId = (Guid)ViewBag.ManagerId;
            var typelist = _user.GetTypeList();
            var suppliers = _user.GetSupplierList(managerId);
            var BrandList = _good.GetAllBrand(managerId);

            ViewBag.TypeList = typelist;
            ViewBag.Supplier = suppliers;
            ViewBag.BrandList = BrandList;
            return View();
        }

        public ActionResult SaveManSong(Manjiusong m, List<int> userType, string areaNums)
        {
            Guid managerId = (Guid)ViewBag.ManagerId;
            var areaList = areaNums.Split(',').ToList();
            var loginUser = (UserInfo)ViewBag.User;
            m.Id = Guid.NewGuid();
            m.CreateTime = DateTime.Now;
            m.CreateUserId = managerId;
            string userTypes = "";
            userType.ForEach(x =>
            {
                userTypes += x;
                userTypes += ",";
            });
            m.UserTypes = userTypes;
            _active.CreateManjiusong(m, areaList);
            Response.Redirect("GetManSongList");
            return View();

        }


        public ActionResult AddNewManJian()
        {
            var loginUser = (UserInfo)ViewBag.User;
            Guid managerId = (Guid)ViewBag.ManagerId;
            var typelist = _user.GetTypeList();
            var suppliers = _user.GetSupplierList(managerId);
            var BrandList = _good.GetAllBrand(managerId);

            ViewBag.TypeList = typelist;
            ViewBag.Supplier = suppliers;
            ViewBag.BrandList = BrandList;
            return View();
        }
        public ActionResult SaveManJian(Manjiujian m, List<int> userType, string areaNums)
        {
            var loginUser = (UserInfo)ViewBag.User;
            Guid managerId = (Guid)ViewBag.ManagerId;
            var areaList = areaNums.Split(',').ToList();
            m.Id = Guid.NewGuid();
            m.CreateTime = DateTime.Now;
            m.CreateUserId = managerId;
            string userTypes = "";
            userType.ForEach(x =>
            {
                userTypes += x;
                userTypes += ",";
            });
            m.UserTypes = userTypes;
            _active.CreateManjiujian(m, areaList);
            Response.Redirect("GetManJianList");
            return View();

        }

        public string CheckGoods(string num)
        {
            var loginUser = (UserInfo)ViewBag.User;
            Guid managerId = (Guid)ViewBag.ManagerId;
            var res = _good.GetGoodsByNum(num, managerId);
            _response.Result = res;
            if (res != null)
                _response.Stutas = true;
            return Utils.SerializeObject(_response);
        }

        public ActionResult GetManSongList(int index = 1)
        {
            Guid managerId = (Guid)ViewBag.ManagerId;
            var loginUser = (UserInfo)ViewBag.User;
            var pager = _active.GetManSongPager(managerId, index);
            ViewBag.Pager = pager;
            return View();
        }



        public ActionResult GetManJianList(int index = 1)
        {
            var loginUser = (UserInfo)ViewBag.User;
            Guid managerId = (Guid)ViewBag.ManagerId;
            var pager = _active.GetManJianPager(managerId, index);
            ViewBag.Pager = pager;
            return View();
        }


        public ActionResult EditManSong(Guid activeId)
        {
            var detail = _active.GetManSongDetial(activeId);
            var loginUser = (UserInfo)ViewBag.User;
            Guid managerId = (Guid)ViewBag.ManagerId;
            var typelist = _user.GetTypeList();
            var suppliers = _user.GetSupplierList(managerId);
            var BrandList = _good.GetAllBrand(managerId);
            var areas = detail.areas.Select(x => x.Num + "_" + x.Name).ToArray();
            ViewBag.AreaStr = string.Join(",", areas);

            ViewBag.TypeList = typelist;
            ViewBag.Supplier = suppliers;
            ViewBag.BrandList = BrandList;

            return View(detail);
        }

        public ActionResult SaveEditManSong(Manjiusong m, List<int> userType, string areaNums)
        {
            var areaList = areaNums.Split(',').ToList();
            var loginUser = (UserInfo)ViewBag.User;
            Guid managerId = (Guid)ViewBag.ManagerId;
            m.CreateTime = DateTime.Now;
            m.CreateUserId = managerId;
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
            var detail = _active.GetManJianDetial(activeId);
            var loginUser = (UserInfo)ViewBag.User;
            Guid managerId = (Guid)ViewBag.ManagerId;
            var typelist = _user.GetTypeList();
            var suppliers = _user.GetSupplierList(managerId);
            var BrandList = _good.GetAllBrand(managerId);
            var areas = detail.areas.Select(x => x.Num + "_" + x.Name).ToArray();
            ViewBag.AreaStr = string.Join(",", areas);

            ViewBag.TypeList = typelist;
            ViewBag.Supplier = suppliers;
            ViewBag.BrandList = BrandList;

            return View(detail);
        }

        public ActionResult SaveEditManJian(Manjiujian m, List<int> userType, string areaNums)
        {
            var areaList = areaNums.Split(',').ToList();
            var loginUser = (UserInfo)ViewBag.User;
            Guid managerId = (Guid)ViewBag.ManagerId;
            m.CreateTime = DateTime.Now;
            m.CreateUserId = managerId;
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


        public ActionResult ShowMyCoupon(int type = -1)
        {
            var loginUser = (UserInfo)ViewBag.User;
            var coupons = _active.GetMyCoupons(loginUser.UserId, type);
            ViewBag.Coupons = coupons;
            ViewBag.TypeId = type;
            return View();
        }

        public ActionResult AddDiscount()
        {
            var loginUser = (UserInfo)ViewBag.User;
            Guid managerId = (Guid)ViewBag.ManagerId;
            ViewBag.TypeList = _good.GetDownGoodsType(Guid.Empty, managerId);
            ViewBag.UserTypeList = _user.GetTypeList();
            return View();
        }


        public ActionResult SaveDiscount(DiscountInfo m, List<int> userType, string areaNums)
        {

            var areaList = areaNums.Split(',').ToList();
            var loginUser = (UserInfo)ViewBag.User;
            m.UpdateTime = DateTime.Now;
            m.UpdateUserId = loginUser.UserId;
            m.UpdateUserName = loginUser.UserName;
            string userTypes = "";
            userType.ForEach(x =>
            {
                userTypes += x;
                userTypes += ",";
            });
            m.UserTypes = userTypes;

            _active.AddDiscountInfo(m, areaList);
            Response.Redirect("DiscountList");

            return View();
        }


        public ActionResult DiscountList()
        {
            Guid managerId = (Guid)ViewBag.ManagerId;
            var loginUser = (UserInfo)ViewBag.User;
            var list = _active.GetDiscountList(managerId);
            ViewBag.DiscountList = list;
            return View();

        }


        public ActionResult EditDiscount(Guid DiscountId)
        {
            Guid managerId = (Guid)ViewBag.ManagerId;
            var loginUser = (UserInfo)ViewBag.User;
            var model = _active.GetDiscountDetail(DiscountId);
            ViewBag.TypeList = _good.GetDownGoodsType(Guid.Empty, managerId);
            ViewBag.UserTypeList = _user.GetTypeList();

            return View(model);
        }



        public string DeleteDiscount(Guid id)
        {
            var res = _active.DeleteDiscount(id);
            return Utils.SerializeObject(res);
        }



        #region

        public ActionResult AddBlackList()
        {
            var loginUser = (UserInfo)ViewBag.User;
            return View();
        }


        public ActionResult SaveBlackList(BlackList m, string areaNums)
        {
            Guid managerId = (Guid)ViewBag.ManagerId;
            var areaList = areaNums.Split(',').ToList();
            var loginUser = (UserInfo)ViewBag.User;
            m.CreateTime = DateTime.Now;
            m.CreateUserId = managerId;
            m.CreateUserName = loginUser.UserName;

            _active.AddBlackList(m, areaList);
            Response.Redirect("BlackListView");
            return View();
        }


        public ActionResult BlackListView()
        {
            Guid managerId = (Guid)ViewBag.ManagerId;
            var loginUser = (UserInfo)ViewBag.User;
            var list = _active.GetBlackList(managerId);
            ViewBag.BlackList = list;
            return View();

        }


        public ActionResult EditBlackList(Guid Id)
        {

            var loginUser = (UserInfo)ViewBag.User;
            var model = _active.GetBlackListDetail(Id);
            return View(model);
        }


        public string DeleteBlackList(Guid id)
        {
            var res = _active.DeleteBlackList(id);
            return Utils.SerializeObject(res);
        }





        #endregion


        #region 单品送





        public ActionResult DPSList(int index = 1)
        {
            Guid managerId = (Guid)ViewBag.ManagerId;
            var loginUser = (UserInfo)ViewBag.User;
            var pager = _active.GetDPSPager(managerId, index);
            ViewBag.Pager = pager;
            return View();
        }
        public ActionResult AddNewDPS()
        {
            var loginUser = (UserInfo)ViewBag.User;

            var typelist = _user.GetTypeList();


            ViewBag.TypeList = typelist;

            return View();
        }

        public ActionResult SaveDPS(DPS m, List<int> userType, string areaNums)
        {
            Guid managerId = (Guid)ViewBag.ManagerId;
            var loginUser = (UserInfo)ViewBag.User;
            var areaList = areaNums.Split(',').ToList();
            m.Id = Guid.NewGuid();
            m.CreateTime = DateTime.Now;
            m.CreateUserId = managerId;
            m.CreateUserName = loginUser.UserName;

            var goodsItem = _good.GetGoodsByNum(m.GoodsNum, managerId);
            var sendGoodsItem = _good.GetGoodsByNum(m.SendGoodsNum, managerId);
            if (goodsItem != null)
            {
                m.GoodsId = goodsItem.Id;
                m.GoodsName = goodsItem.GoodsTittle;
            }

            if (sendGoodsItem != null)
            {
                m.SendGoodsId = sendGoodsItem.Id;
                m.SendGoodsName = sendGoodsItem.GoodsTittle;
            }
            string userTypes = "";
            userType.ForEach(x =>
            {
                userTypes += x;
                userTypes += ",";
            });
            m.UserTypes = userTypes;
            _active.CreateDPS(m, areaList);

            Response.Redirect("DPSList");

            return View();
        }



        public ActionResult EditDPS(Guid Id)
        {
            var detail = _active.GetDPSDetial(Id);
            var loginUser = (UserInfo)ViewBag.User;
            Guid managerId = (Guid)ViewBag.ManagerId;
            var typelist = _user.GetTypeList();

            var areas = detail.areas.Select(x => x.Num + "_" + x.Name).ToArray();
            ViewBag.AreaStr = string.Join(",", areas);

            ViewBag.TypeList = typelist;


            return View(detail);
        }

        public ActionResult SaveEdiEditDPS(DPS m, List<int> userType, string areaNums)
        {
            var areaList = areaNums.Split(',').ToList();
            var loginUser = (UserInfo)ViewBag.User;
            Guid managerId = (Guid)ViewBag.ManagerId;
            m.CreateTime = DateTime.Now;
            m.CreateUserId = managerId;

            var goodsItem = _good.GetGoodsByNum(m.GoodsNum, managerId);
            var sendGoodsItem = _good.GetGoodsByNum(m.SendGoodsNum, managerId);
            if (goodsItem != null)
            {
                m.GoodsId = goodsItem.Id;
                m.GoodsName = goodsItem.GoodsTittle;
            }

            if (sendGoodsItem != null)
            {
                m.SendGoodsId = sendGoodsItem.Id;
                m.SendGoodsName = sendGoodsItem.GoodsTittle;
            }
            string userTypes = "";
            userType.ForEach(x =>
            {
                userTypes += x;
                userTypes += ",";
            });
            m.UserTypes = userTypes;
            _active.SaveDPS(m, areaList);
            Response.Redirect("DPSList");
            return View();
        }
        #endregion


        #region  新增活动黑名单

        public ActionResult AddActiveBlacklist(int page = 1, string key = "")
        {
            var loginUser = (UserInfo)ViewBag.User;
            Guid managerId = (Guid)ViewBag.ManagerId;
            var goodsList = _good.GetGoodsList(managerId, -1, page, 30, "", "", "", "", "", key, "");
            ViewBag.GoodsList = goodsList;
            ViewBag.Key = key;
            ViewBag.Page = page;
            return View();
        }

        public string SaveActiveBlacklist(string goodsIds, int type)
        {
            var strs = goodsIds.Split('|');
            List<Guid> list = new List<Guid>();
            foreach (var str in strs)
            {
                if (!string.IsNullOrWhiteSpace(str))
                    list.Add(Utils.ParseGuid(str));
            }

            var loginUser = (UserInfo)ViewBag.User;
            Guid managerId = (Guid)ViewBag.ManagerId;
            var res = _active.SaveBlackFoActive(list, managerId, type);
            return Utils.SerializeObject(res);
        }

        public ActionResult ShowActiveBlacklist(int index = 1, int type = 0, string key = "")
        {
            var pager = _active.GetBlackForActiveByPage(index, type, key);

            ViewBag.Page = pager;
            ViewBag.ActiveType = type;
            ViewBag.Key = key;
            return View();
        }

        public string DeleteBlackForActive(List<Guid> ids)
        {
            _response = _active.DeleteBlackForActive(ids);
            return Utils.SerializeObject(_response);
        }

        #endregion



        #region 优惠券活动

        public ActionResult ShowCouponActivites(int index = 1 )
        {

            Guid managerId = (Guid)ViewBag.ManagerId;
            var loginUser = (UserInfo)ViewBag.User;
            var pager = _active.GetCouponActivityPager(managerId, index);
            ViewBag.Pager = pager;
            return View();
        }

        public ActionResult CreateCouponActivity()
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


        public ActionResult SaveCouponActivity(CouponActivity c, List<int> userType, string areaNums)
        {
            var loginUser = (UserInfo)ViewBag.User;
            var areaList = areaNums.Split(',').ToList();

            var userList = new List<UserInfo>();
            Guid managerId = (Guid)ViewBag.ManagerId;
            c.CreateTime = DateTime.Now;
            c.CreateUserId = managerId;
            c.CreateUserName = loginUser.UserName;
            string userTypes = "";
            userType.ForEach(x =>
            {
                userTypes += x;
                userTypes += ",";
            });
            c.UserTypes = userTypes;
            _active.CreateCouponActivity(c, areaList);
            Response.Redirect("ShowCouponActivites");
            return View();
        }


        #endregion
    }
}