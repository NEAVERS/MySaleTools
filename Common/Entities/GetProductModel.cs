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

        public List<GetProductItem> Items { get; set; }
    }

    public class GetProductItem
    {
        public string  ProductName { get; set; }

        public string  BarCode { get; set; }

        public string Spec { get; set; }

        public string  Unit { get; set; }

        public decimal  Pirce { get; set; }

        public int Count { get; set; }


        public decimal  TotalPirce { get; set; }

        public string  Remark { get; set; }
    }
}
