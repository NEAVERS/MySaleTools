using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaleTools.Controllers
{
    public class OrderController : Controller
    {
        private OrderManager _order = new OrderManager();
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }
    }
}