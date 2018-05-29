using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CommissionRulePtype
    {
        public decimal BillNumberId { get; set; }
        public decimal ID { get; set; }
        public string EtypeID { get; set; }
        public string PtypeID { get; set; }
        public Nullable<decimal> Proportion { get; set; }
    }
}
