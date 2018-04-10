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

        public ActionResult PrintOrder(string start = "", string end = "", string province = "", string city = "", string area = "", int stutas = 0, string saleManId = "", int userType = 0, string key = "")
        {

            DateTime startTime = Utils.GetTime(start, true);
            DateTime endTime = Utils.GetTime(end);
            Guid managerId = Guid.NewGuid();
            var loginUser = (UserInfo)ViewBag.User;
            if (ViewBag.IsAdmin)
                managerId = loginUser.UserId;
            else
                managerId = loginUser.SaleManGuid;
            PageData<OrderInfo> pager = _order.GetOrderList(1, 10000, startTime, endTime, province, city, area, stutas, saleManId, userType, key, managerId, ViewBag.IsAdmin);
            var list = new List<OrderDetail>();

            pager.ListData.ForEach(x =>
            {
                var model = _order.GetOrderDetail(x.Id);
                model.User = _user.GetUserByUserId(x.CreateUserId);
                list.Add(model);
            });
            ViewBag.List = list;
            return View();
        }



       public ActionResult CreateFile()
        {

            return View();
        }


        public ActionResult OutpuFile(string start="",string end ="")
        {
            DateTime startTime = Utils.GetTime(start, true);
            DateTime endTime = Utils.GetTime(end);
            var result = _order.CreateOrderFile(startTime, endTime);
            return File(result, "text/comma-separated-values", "demo1.csv");
        }


        public ActionResult GetBill()
        {
            var loginUser = (UserInfo)Session["LoginUser"];
            Guid mangerId = loginUser.CreateUserId;
            if (ViewBag.IsAdmin)
                mangerId = loginUser.UserId;
            var supplierList = _user.GetSupplierList(mangerId);
            ViewBag.SupplierList = supplierList;
            return View();
        }


        public ActionResult  ShowGetBill(string start = "",string end = "", int SupplierId = -1)
        {
            DateTime startTime = Utils.GetTime(start, true);
            DateTime endTime = Utils.GetTime(end);
            var result = _order.GetProductBill(startTime, endTime, SupplierId);
            ViewBag.List = result;
            ViewBag.Start = startTime.ToString("yyyy-MM-dd HH:mm:ss");
            ViewBag.End = endTime.ToString("yyyy-MM-dd HH:mm:ss");
            ViewBag.Tel = new SystemManager().GetConfig(SysConfigTypes.ContactTell).Value;

            return View();
        }


        public ActionResult ShowPickUpBill(string start = "", string end = "", int SupplierId = 3)
        {
            DateTime startTime = Utils.GetTime(start, true);
            DateTime endTime = Utils.GetTime(end);
            var result = _order.GetPickUpBill(startTime, endTime, SupplierId);
            ViewBag.List = result;
            return View();
        }

        public ActionResult ConfirmPayRecord(string orderNum= "")
        {
            var loginUser = (UserInfo)ViewBag.User;

            var Sendlist = _user.GetSysUser((int)SystemUserType.送货员, loginUser.CreateUserId);
            ViewBag.SendPeople = Sendlist;
            bool IsTurn = false;
            OrderDetail model = new OrderDetail();
            if (!string.IsNullOrWhiteSpace(orderNum))
            {
                model = _order.GetOrderDetail(orderNum);
                IsTurn = true;
            }
            List<ErrorReason> list = _order.GetErrorReasonByType(1);
            ViewBag.ErrorList = list;
            ViewBag.IsTurn = IsTurn;
            return View(model);
        }


        public string LoadErrorReason(string pid)
        {
            var list = _order.GetErrorReasonByType(2, pid);
            return Utils.SerializeObject(list);
        }

        public string SetOrderItemError(Guid orderItemId, int count, string typeCode, string type, string reasonCode, string reason, string mark)
        {
            var res = _order.SetErrorInfo(orderItemId, count, typeCode, type, reasonCode, reason, mark);
            return Utils.SerializeObject(res);
        }

        public string ConfirmOrderPay(Guid orderId,decimal paymoeney,string remark,Guid send)
        {
            var res = _order.ConfirmOrderPay(orderId, paymoeney, remark, send);
            return Utils.SerializeObject(res);
        }


        public string SaveRemark(Guid orderId, string remark)
        {
            var res = _order.SaveOrderRemark(orderId, remark);
            return Utils.SerializeObject(res);

        }

    }
}