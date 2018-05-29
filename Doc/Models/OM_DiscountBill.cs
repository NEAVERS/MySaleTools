using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OM_DiscountBill
    {
        public int BillNumberID { get; set; }
        public Nullable<int> BillIndex_ID { get; set; }
        public Nullable<decimal> OldDiscount { get; set; }
        public Nullable<decimal> NewDiscount { get; set; }
        public string ModReason { get; set; }
    }
}
