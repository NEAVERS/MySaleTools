using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class EtypeSaleplan
    {
        public int ID { get; set; }
        public Nullable<int> EplanID { get; set; }
        public string EtypeID { get; set; }
        public string DtypeID { get; set; }
        public string StypeID { get; set; }
        public Nullable<int> TimeID { get; set; }
        public Nullable<decimal> RatingValue { get; set; }
        public Nullable<decimal> PlanValue { get; set; }
        public Nullable<decimal> ApportionScale { get; set; }
    }
}
