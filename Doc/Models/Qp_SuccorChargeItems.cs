using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Qp_SuccorChargeItems
    {
        public int SuccorChargeId { get; set; }
        public string FullName { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string PYCode { get; set; }
    }
}
