using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PromoRule_Detail_VIPConfig
    {
        public decimal ID { get; set; }
        public decimal PromoRuleID { get; set; }
        public Nullable<int> VipTypeID { get; set; }
        public string StartCardNum { get; set; }
        public string EndCardNum { get; set; }
    }
}
