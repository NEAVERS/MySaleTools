using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class DtypeSaleplan
    {
        public int ID { get; set; }
        public Nullable<int> DplanID { get; set; }
        public string DtypeID { get; set; }
        public Nullable<int> TimeID { get; set; }
        public string StypeID { get; set; }
        public Nullable<decimal> RatingValue { get; set; }
        public Nullable<decimal> PlanValue { get; set; }
        public Nullable<decimal> ApportionScale { get; set; }
    }
}
