using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class DtypeSaleAllPlan
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public Nullable<int> TotalID { get; set; }
        public Nullable<int> STypePlanID { get; set; }
        public Nullable<decimal> AllPlanValue { get; set; }
        public Nullable<decimal> AllRatingValue { get; set; }
        public Nullable<int> TimeID { get; set; }
        public Nullable<bool> IfAudit { get; set; }
        public string Comment { get; set; }
        public Nullable<byte> IfUse { get; set; }
        public string MoneyUnit { get; set; }
    }
}
