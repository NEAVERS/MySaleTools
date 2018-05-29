using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PriceRulePriority
    {
        public decimal ID { get; set; }
        public Nullable<decimal> PriceRuleID { get; set; }
        public string StypeID { get; set; }
        public Nullable<int> SortID { get; set; }
    }
}
