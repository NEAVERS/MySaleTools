using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class DiyBill
    {
        public decimal BillNumberId { get; set; }
        public string PtypeId { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> SalePrice { get; set; }
        public string Comment { get; set; }
        public Nullable<decimal> SaleTotal { get; set; }
        public string typeId { get; set; }
    }
}
