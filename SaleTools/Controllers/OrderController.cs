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
    public class OrderController : BaseController
    {
        private OrderManager _order = new OrderManager();
        private UserManager _user = new UserManager();
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult CreateOrder()
        {
            return View();
        }


        public ActionResult OrderManager()
        {
            var loginUser = (UserInfo)ViewBag.User;
            var list = _user.GetTypeList();
            ViewBag.TypeList = list;
            var saleList = _user.GetSysUser((int)SystemUserType.业务员, loginUser.CreateUserId);
            ViewBag.SaleManList = saleList;

            return View();
        }


        public ActionResult OrderSearch()
        {
            var loginUser = (UserInfo)ViewBag.User;
            var list = _user.GetTypeList();
            ViewBag.TypeList = list;
            var saleList = _user.GetSysUser((int)SystemUserType.业务员, loginUser.CreateUserId);
            ViewBag.SaleManList = saleList;

            return View();
        }

        public string GetOrderList(int index, int size, string start="", string end ="", string province="", string city="", string area="0", int stutas = -1, string saleManId ="", int userType =-1, string key="" )
        {

            DateTime startTime = Utils.GetTime(start, true);
            DateTime endTime = Utils.GetTime(end);
            Guid managerId = Guid.NewGuid();
            var loginUser = (UserInfo)ViewBag.User;
            if (ViewBag.IsAdmin)
                managerId = loginUser.UserId;
            else
                managerId = loginUser.SaleManGuid;
            var pager = _order.GetOrderList(index,size,startTime,endTime,province,city,area,stutas,saleManId,userType,key,managerId, ViewBag.IsAdmin);
            return Utils.SerializeObject(pager);
        }

        public string CancelOrder(Guid orderId)
        {
            var res = _order.CancelOrder(orderId);
            return Utils.SerializeObject(res);
        }
    }
}