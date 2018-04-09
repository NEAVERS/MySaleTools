using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class GetProductModel
    {
        public Supplier SupplierInfo { get; set; }

        public List<OrderItem> Items { get; set; }
    }
}
