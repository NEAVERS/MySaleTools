using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CommissionRuleLeader
    {
        public decimal BillNumberId { get; set; }
        public decimal ID { get; set; }
        public string CommissionTypeID { get; set; }
        public Nullable<decimal> MinRegion { get; set; }
        public Nullable<decimal> MaxRegion { get; set; }
        public Nullable<decimal> Proportion { get; set; }
        public string EtypeID { get; set; }
    }
}
