using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class IniStockAgeGroup
    {
        public int ID { get; set; }
        public string KtypeID { get; set; }
        public string PtypeID { get; set; }
        public string InStockDate { get; set; }
        public Nullable<decimal> StockAge { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> Total { get; set; }
    }
}
