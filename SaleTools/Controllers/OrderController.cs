using BLL;
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
            return View();
        }


        public ActionResult OrderSearch()
        {
            return View();
        }

        public string GetOrderList(int index, int size, string start="", string end ="", string province="", string city="", string area="0", int stutas = -1, string saleManId ="", int userType =-1, string key="" )
        {

            return "";
        }
    }
}