using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ToolBill
    {
        public decimal BillNumberId { get; set; }
        public int ID { get; set; }
        public string PTypeID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string ValidDate { get; set; }
        public string Comment { get; set; }
        public Nullable<int> IsUnit2 { get; set; }
    }
}
