using BLL;
using Common;
using Common.Entities;
using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaleTools.Controllers
{
    public class OrderController : BaseController
    {
        private OrderManager _order = new OrderManager();
        private UserManager _user = new UserManager();

        private GoodsManager _good = new GoodsManager();
        private ResponseModel _response = new ResponseModel();
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
            Guid managerId = (Guid)ViewBag.ManagerId;
            var list = _user.GetTypeList();
            ViewBag.TypeList = list;
            var saleList = _user.GetSysUser((int)SystemUserType.业务员, managerId);
            ViewBag.SaleManList = saleList;

            return View();
        }


        public ActionResult OrderSearch()
        {
            var loginUser = (UserInfo)ViewBag.User;
            Guid managerId = (Guid)ViewBag.ManagerId;
            var list = _user.GetTypeList();
            ViewBag.TypeList = list;
            var saleList = _user.GetSysUser((int)SystemUserType.业务员, managerId);
            ViewBag.SaleManList = saleList;

            return View();
        }

        public string GetOrderList(int index, int size, string start="", string end ="", string province="", string city="", string area="0", int stutas = -1, string saleManId ="", int userType =-1, string key="",bool isDown = false)
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
        public string GetOrderTotal(int index, int size, string start = "", string end = "", string province = "", string city = "", string area = "0", int stutas = -1, string saleManId = "", int userType = -1, string key = "", bool isDown = false)
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
            var total = new
            {
                totalCount = pager.ListData.Count,
                totalMoney = pager.ListData.Sum(x => x.TotalMoney)
            };
            return Utils.SerializeObject(total);
        }



        public ActionResult ExportOrderInfo( string start = "", string end = "", string province = "", string city = "", string area = "0", int stutas = -1, string saleManId = "", int userType = -1, string key = "")
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
            var result = _order.CreateOrderInfoFile(pager.ListData);
            return File(result, "text/comma-separated-values", Guid.NewGuid().ToString("N") + ".csv");
        }

        public string CancelOrder(Guid orderId)
        {

            var Resourse = (List<string>)ViewBag.Resourse;
            if(Resourse.Contains(ResourceStr.CancelOrder)|| Resourse.Contains(ResourceStr.SuperAdmin))
            {
                _response.Stutas = _order.CancelOrder(orderId);

            }
            else
            {
                _response.Msg = "您暂无权限取消订单，请联系管理员";
            }
            return Utils.SerializeObject(_response);
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

        /// <summary>
        /// 导出订单
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public ActionResult OutpuFile(string start="",string end ="",string key= "")
        {
            DateTime startTime = Utils.GetTime(start, true);
            DateTime endTime = Utils.GetTime(end);
            var result = _order.CreateOrderFile(startTime, endTime, key.Trim());
            return File(result, "text/comma-separated-values",  Guid.NewGuid().ToString("N")+".csv");
        }


        public ActionResult GetBill()
        {
            var loginUser =  (UserInfo)ViewBag.User;;
            Guid mangerId = loginUser.CreateUserId;
            if (ViewBag.IsAdmin)
                mangerId = loginUser.UserId;
            var supplierList = _user.GetSupplierList(mangerId);
            ViewBag.SupplierList = supplierList;
            return View();
        }

        /// <summary>
        /// 展示取货单
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="SupplierId"></param>
        /// <returns></returns>
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


        public ActionResult PickUpBill()
        {
            var loginUser =  (UserInfo)ViewBag.User;;
            Guid mangerId = loginUser.CreateUserId;
            if (ViewBag.IsAdmin)
                mangerId = loginUser.UserId;
            var supplierList = _user.GetSupplierList(mangerId);
            ViewBag.SupplierList = supplierList;

            return View();
        }
        /// <summary>
        /// 展示拣货单
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="SupplierId"></param>
        /// <returns></returns>

        public ActionResult ShowPickUpBill(string start = "", string end = "", int SupplierId = 3)
        {
            DateTime startTime = Utils.GetTime(start, true);
            DateTime endTime = Utils.GetTime(end);
            var result = _order.GetPickUpBill(startTime, endTime, SupplierId);
            ViewBag.List = result;
            return View();
        }
        /// <summary>
        /// 订单收款登记
        /// </summary>
        /// <param name="orderNum"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 加载异常原因
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public string LoadErrorReason(string pid)
        {
            var list = _order.GetErrorReasonByType(2, pid);
            return Utils.SerializeObject(list);
        }

        /// <summary>
        /// 设置订单子项的异常信息
        /// </summary>
        /// <param name="orderItemId"></param>
        /// <param name="count"></param>
        /// <param name="typeCode"></param>
        /// <param name="type"></param>
        /// <param name="reasonCode"></param>
        /// <param name="reason"></param>
        /// <param name="mark"></param>
        /// <returns></returns>
        public string SetOrderItemError(Guid orderItemId, int count, string typeCode, string type, string reasonCode, string reason, string mark)
        {
            var res = _order.SetErrorInfo(orderItemId, count, typeCode, type, reasonCode, reason, mark);
            return Utils.SerializeObject(res);
        }
        /// <summary>
        /// 整单退货
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public string SetAllItemError(Guid orderId)
        {
            var res = _order.SetAllOrderError(orderId, "1001", "退货", "1015", "退6:整单退货");
            return Utils.SerializeObject(res);
        }

        /// <summary>
        /// 确认订单付款信息
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="paymoeney"></param>
        /// <param name="remark"></param>
        /// <param name="send"></param>
        /// <returns></returns>
        public string ConfirmOrderPay(Guid orderId,decimal paymoeney,string remark,Guid send)
        {
            var loginUser = (UserInfo)ViewBag.User;

            var res = _order.ConfirmOrderPay(loginUser.UserId, orderId, paymoeney, remark, send);
            return Utils.SerializeObject(res);
        }

        /// <summary>
        /// 订单收款登记页面保存备注
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="remark"></param>
        /// <returns></returns>
        public string SaveRemark(Guid orderId, string remark)
        {
            var res = _order.SaveOrderRemark(orderId, remark);
            return Utils.SerializeObject(res);

        }


        public ActionResult OrderPayContrast()
        {
            var loginUser = (UserInfo)ViewBag.User;
            Guid managerId = (Guid)ViewBag.ManagerId;
            var Sendlist = _user.GetSysUser((int)SystemUserType.送货员, managerId);
            ViewBag.SendPeople = Sendlist;
            var SaleList = _user.GetSysUser((int)SystemUserType.业务员, managerId);
            ViewBag.SalePeople = SaleList;
            var typeList = _user.GetTypeList();
            ViewBag.TypeList = typeList;
            return View();
        }

        /// <summary>
        /// 获取订单列表
        /// </summary>
        /// <param name="timeType"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="orderNum"></param>
        /// <param name="send"></param>
        /// <param name="sale"></param>
        /// <param name="uerType"></param>
        /// <param name="paystutas"></param>
        /// <returns></returns>
        public string GetPayContrast(int timeType,string start,string end,string orderNum,string send,string sale,int uerType,int paystutas = -1 )
        {
            DateTime startTime = Utils.GetTime(start, true);
            DateTime endTime = Utils.GetTime(end);
            Guid sendId = Utils.ParseGuid(send);
            Guid saleId = Utils.ParseGuid(sale);
            var list = _order.GetOrderForPayContrast((Guid)ViewBag.ManagerId, timeType, startTime,endTime, orderNum,sendId,saleId, uerType, paystutas);

            var mode = new
            {
                OrderCout = list.Count,
                PayCount = list.Where(x => x.IsPay).Count(),
                PayMoeny = list.Where(x => x.IsPay).Sum(x => x.PayMoney),
                NotPayCount = list.Where(x => !x.IsPay).Count(),
                NotPayMoeny = list.Where(x => !x.IsPay).Sum(x => x.RealMoney),
                ListData= list,
            };
            return Utils.SerializeObject(mode);
        }

        /// <summary>
        /// 撤销已支付状态
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public string RevertOrderIsPay(Guid orderId)
        {
            var Resourse = (List<string>)ViewBag.Resourse;
            if (Resourse.Contains(ResourceStr.CancelOrder)|| Resourse.Contains(ResourceStr.SuperAdmin))
            {
                _response.Stutas = _order.RevertIsPay(orderId);

            }
            else
            {
                _response.Msg = "您暂无权限撤销订单收款，请联系管理员";
            }
            return Utils.SerializeObject(_response);
        }

        public ActionResult AbnormalOrder(string start ="",string end="")
        {
            DateTime startTime = new DateTime();
            DateTime endTime = new DateTime();
            DateTime now = DateTime.Now;
            DateTime dateTime = now.AddDays(-1);
            if (string.IsNullOrEmpty(start))
                startTime = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 16, 0, 0);
            else
                startTime = Utils.GetTime(start, true);
            if (string.IsNullOrEmpty(end))
                endTime = new DateTime(now.Year, now.Month, now.Day , 16, 0, 0);
            else
                endTime = Utils.GetTime(end);

            var list = _order.GetOrderForPayContrast((Guid)ViewBag.ManagerId, 2, startTime, endTime, "", Guid.Empty, Guid.Empty ,- 1, 1);
            ViewBag.List = list;
            return View();

        }

        /// <summary>
        /// 订单综合统计
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="province"></param>
        /// <param name="city"></param>
        /// <param name="area"></param>
        /// <param name="orderMoney"></param>
        /// <param name="showType"></param>
        /// <param name="saleManId"></param>
        /// <returns></returns>
        public ActionResult OrderCount(string start = "", string end = "", string province = "", string city = "", string area = "", decimal orderMoney = 0, int showType = 0, string saleManId = "", bool isDown = false)
        {
            

            Guid managerId = (Guid)ViewBag.ManagerId;
            var SaleList = _user.GetSysUser((int)SystemUserType.业务员, managerId);
            var OrderList = new List<OrderCountByStore>();
            DateTime startTime = new DateTime();
            DateTime endTime = new DateTime();
            DateTime now = DateTime.Now;
            DateTime dateTime = now.AddDays(-1);

            if (string.IsNullOrEmpty(start))
                startTime = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day , 16, 0, 0);
            else
                startTime = Utils.GetTime(start, true);
            if (string.IsNullOrEmpty(end))
                endTime = new DateTime(now.Year, now.Month, now.Day, 16, 0, 0);
            else
                endTime = Utils.GetTime(end);

            if (!string.IsNullOrWhiteSpace(start))
            {
                if (showType == 0||isDown)
                {
                    OrderList = _order.GetOrderTotal(startTime, endTime, province, city, area, managerId, orderMoney);

                }
                else
                {
                    OrderList = _order.GetOrderTotalBySaleMan(startTime, endTime, managerId);
                }
            }
            if(isDown)
            {
                var result = _order.CreateOrderCountFile(OrderList);
                return File(result, "text/comma-separated-values", "demo1.csv");

            }

            ViewBag.Start = startTime;
            ViewBag.End = endTime;
            ViewBag.Province = province;
            ViewBag.City = city;
            ViewBag.Area = area;
            ViewBag.OrderMoney = orderMoney;
            ViewBag.SaleManId = saleManId;
            ViewBag.SalePeople = SaleList;
            ViewBag.ShowType = showType;
            ViewBag.OrderList = OrderList;
            ViewBag.ShowType = showType;
            return View();
        }
        /// <summary>
        /// 商品销售统计
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public ActionResult ShopCount(string start = "", string end = "", string key = "",string typeId="")
        {
            Guid managerId = (Guid)ViewBag.ManagerId;
            var typeList = _good.GetDownGoodsType(Guid.Empty, managerId);
            var list = new List<GoodsSaleMode>();
            DateTime startTime = new DateTime();
            DateTime endTime = new DateTime();
            DateTime now = DateTime.Now;
            DateTime dateTime = now.AddDays(-1);

            if (string.IsNullOrEmpty(start))
                startTime = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day , 16, 0, 0);
            else
                startTime = Utils.GetTime(start, true);
            if (string.IsNullOrEmpty(end))
                endTime = new DateTime(now.Year, now.Month, now.Day, 16, 0, 0);
            else
                endTime = Utils.GetTime(end);
            if(!string.IsNullOrWhiteSpace(start))
            {
                list = _order.GetGoodsSaleInfo(startTime, endTime, key, typeId, managerId);
            }

            ViewBag.TypeList = typeList;
            ViewBag.List = list;
            ViewBag.Start = startTime;
            ViewBag.End = endTime;
            ViewBag.Key = key;
            ViewBag.TypeId = typeId;
            return View();
        }


        public ActionResult AbnormalCount(string start = "",string end ="",string cType ="",string goodsType = "",int supplier = -1,int Stype =1)
        {
            
            Guid managerId = (Guid)ViewBag.ManagerId;
            var list = new List<ErrorInfoModel>();
            var typeList = _good.GetDownGoodsType(Guid.Empty, managerId);
            var supplierList = _user.GetSupplierList(managerId);

            DateTime startTime = new DateTime();
            DateTime endTime = new DateTime();
            DateTime now = DateTime.Now;
            DateTime dateTime = now.AddDays(-1);
            if (string.IsNullOrEmpty(start))
                startTime = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day , 16, 0, 0);
            else
                startTime = Utils.GetTime(start, true);
            if (string.IsNullOrEmpty(end))
                endTime = new DateTime(now.Year, now.Month, now.Day, 16, 0, 0);
            else
                endTime = Utils.GetTime(end);

            if (!string.IsNullOrWhiteSpace(start))
            {
                list = _order.GetErrorInfo(startTime, endTime, cType, supplier,goodsType, Stype);
            }
            ViewBag.SupplierList = supplierList;

            ViewBag.TypeList = typeList;
            ViewBag.List = list;
            ViewBag.Start = startTime;
            ViewBag.End = endTime;
            ViewBag.CType = cType;
            ViewBag.GoodsType = goodsType;


            ViewBag.Supplier = supplier;
            ViewBag.Stype = Stype;

            return View();
        }
        /// <summary>
        /// 异常天数统计
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public ActionResult AbnormalNumber(string start = "",string end = "")
        {
            Guid managerId = (Guid)ViewBag.ManagerId;

            DateTime startTime = new DateTime();
            DateTime endTime = new DateTime();
            DateTime now = DateTime.Now;
            DateTime date = now.AddDays(-1);
            if (string.IsNullOrEmpty(start))
                startTime = new DateTime(date.Year, date.Month, date.Day , 16, 0, 0);
            else
                startTime = Utils.GetTime(start, true);
            if (string.IsNullOrEmpty(end))
                endTime = new DateTime(now.Year, now.Month, now.Day, 16, 0, 0);
            else
                endTime = Utils.GetTime(end);
            var list = new List<ErrorDayModel>();
            if(!string.IsNullOrWhiteSpace(start))
            {
                list = _order.GetErrDays(startTime, endTime, managerId);
            }
            ViewBag.Start = startTime;
            ViewBag.End = endTime;
            ViewBag.List = list;
            return View();
        }



        public ActionResult UserOrderManager(string start = "",string end ="")
        {
           
            UserInfo userInfo = (UserInfo)ViewBag.User;
            DateTime startTime = new DateTime();
            DateTime endTime = new DateTime();
            DateTime now = DateTime.Now;
            DateTime date = now.AddDays(-1);
            if (string.IsNullOrEmpty(start))
                startTime = new DateTime(date.Year, date.Month, date.Day, 16, 0, 0);
            else
                startTime = Utils.GetTime(start, true);
            if (string.IsNullOrEmpty(end))
                endTime = new DateTime(now.Year, now.Month, now.Day, 16, 0, 0);
            else
                endTime = Utils.GetTime(end);

            var list = _order.UserGetOrderInfos(startTime, endTime, userInfo.UserId);
            ViewBag.List = list;
            ViewBag.Start = startTime;
            ViewBag.End = endTime;
            return View();
        }

        /// <summary>
        /// 用户取消订单
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public string UserCancelOrder(Guid orderId)
        {
            var response = _order.UserCancelOrder(orderId);
            return Utils.SerializeObject(response);
        }



        public string RecoverOrder(Guid orderId)
        {
            _response.Stutas = _order.RecoverOrder(orderId);
            return Utils.SerializeObject(_response);

        }


        public string ReBuy(Guid orderId)
        {
            _response.Stutas = _order.ReBuy(orderId);
            return Utils.SerializeObject(_response);
        }
        /// <summary>
        /// 审核取消订单
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="isAgree"></param>
        /// <returns></returns>
        public string OrderCheck(Guid orderId,bool isAgree)
        {
            var res = _order.CheckCancel(orderId, isAgree);
            return Utils.SerializeObject(res);
        }

        public string CancelError(Guid itmeId)
        {
            var res = _order.CancelError(itmeId);
            if (res)
                _response.Stutas = true;
            else
                _response.Msg = "取消异常失败！";
            return Utils.SerializeObject(res);

        }



        public ActionResult OrderDetail(Guid orderId )
        {
            var model = _order.GetOrderDetail(orderId);

            return View(model);
        }

        public string InsertErp(Guid orderid)
        {
            bool res = false;
            try
            {
                 res = _order.InsertErp(orderid);
            }
            catch (Exception ex)
            {
                LogsHelper.WriteErrorLog(ex, "导入Erp");
            }
            return res.ToString();
        }
    }
}