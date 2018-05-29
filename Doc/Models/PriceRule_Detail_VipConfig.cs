using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PriceRule_Detail_VipConfig
    {
        public decimal ID { get; set; }
        public Nullable<decimal> PriceRuleID { get; set; }
        public Nullable<int> VipTypeID { get; set; }
        public string StartCardNum { get; set; }
        public string EndCardNum { get; set; }
    }
}
