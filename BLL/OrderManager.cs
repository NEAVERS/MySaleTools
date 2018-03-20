using Common.Entities;
using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderManager
    {
        private SaleToolsContext _context = new SaleToolsContext();



        public List<OrderItem> GetShoppingCar(Guid userId)
        {
            return null;
        }

    }
}
