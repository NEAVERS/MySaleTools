using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class EtypeSaleAllPlan
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public Nullable<int> TotalID { get; set; }
        public Nullable<int> DTypePlanID { get; set; }
        public Nullable<decimal> AllPlanValue { get; set; }
        public Nullable<decimal> AllRatingValue { get; set; }
        public string Comment { get; set; }
        public Nullable<bool> IfAudit { get; set; }
        public Nullable<byte> IfUse { get; set; }
        public string MoneyUnit { get; set; }
    }
}
