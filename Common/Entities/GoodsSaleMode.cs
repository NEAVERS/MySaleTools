using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class GoodsSaleMode
    {
        public int Num { get; set; }

        public string  TypeName { get; set; }

        public string Supplier { get; set; }

        public string  ProductName { get; set; }

        public string BarCode { get; set; }

        public decimal SalePrice { get; set; }

        public decimal CostPrice { get; set; }

        public int TotalCount { get; set; }

        public decimal TotalMoney { get; set; }
    }
}
