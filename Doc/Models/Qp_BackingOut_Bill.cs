using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Qp_BackingOut_Bill
    {
        public decimal BillNumberId { get; set; }
        public string BackingOutReason { get; set; }
        public string BackingOutCheck { get; set; }
        public string BackingOutResult { get; set; }
        public Nullable<int> BackingOutState { get; set; }
    }
}
