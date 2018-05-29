using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class GuestBack
    {
        public decimal BillNumberId { get; set; }
        public string PtypeId { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> SalePrice { get; set; }
        public Nullable<decimal> discount { get; set; }
        public Nullable<decimal> DiscountPrice { get; set; }
        public string jobnumber { get; set; }
        public Nullable<int> goodsno { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<System.DateTime> OutFactoryDate { get; set; }
        public Nullable<decimal> TaxPrice { get; set; }
        public Nullable<decimal> TaxTotal { get; set; }
        public string comment { get; set; }
        public Nullable<int> ID { get; set; }
        public Nullable<int> TeamNO1 { get; set; }
    }
}
