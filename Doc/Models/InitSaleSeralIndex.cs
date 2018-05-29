using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class InitSaleSeralIndex
    {
        public decimal BillNumberId { get; set; }
        public System.DateTime BillDate { get; set; }
        public string BillCode { get; set; }
        public decimal BillType { get; set; }
        public string Comment { get; set; }
        public string checke { get; set; }
        public string explain { get; set; }
        public string Stypeid { get; set; }
        public Nullable<bool> IsIni { get; set; }
    }
}
