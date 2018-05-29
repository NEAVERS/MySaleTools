using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class StockCheckIndex
    {
        public int StockCheckID { get; set; }
        public Nullable<bool> Pass { get; set; }
        public System.DateTime BillDate { get; set; }
        public string BillCode { get; set; }
        public string KTypeID { get; set; }
        public string ETypeID { get; set; }
        public string Comment { get; set; }
        public Nullable<int> ifWX { get; set; }
        public System.DateTime StockQtyEndDate { get; set; }
    }
}
