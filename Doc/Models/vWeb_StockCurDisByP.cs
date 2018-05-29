using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class vWeb_StockCurDisByP
    {
        public string SFullName { get; set; }
        public string PFullName { get; set; }
        public string PTypeid { get; set; }
        public string Ktypeid { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> Price { get; set; }
    }
}
