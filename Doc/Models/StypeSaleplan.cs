using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class StypeSaleplan
    {
        public int ID { get; set; }
        public Nullable<int> SplanID { get; set; }
        public string StypeID { get; set; }
        public Nullable<decimal> RatingValue { get; set; }
        public Nullable<decimal> PlanValue { get; set; }
        public Nullable<decimal> ApportionScale { get; set; }
        public Nullable<int> TimeID { get; set; }
    }
}
