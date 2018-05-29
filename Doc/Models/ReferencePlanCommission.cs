using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ReferencePlanCommission
    {
        public decimal BillNumberId { get; set; }
        public string BillCode { get; set; }
        public string FullName { get; set; }
        public System.DateTime BillDate { get; set; }
        public System.DateTime PlanStart { get; set; }
        public System.DateTime PlanEnd { get; set; }
        public int CommissionStandard { get; set; }
        public string Checke { get; set; }
        public string Checker { get; set; }
        public System.DateTime CheckeTime { get; set; }
        public Nullable<System.DateTime> CheckerTime { get; set; }
        public string Comment { get; set; }
        public int BillState { get; set; }
        public int UseState { get; set; }
        public int IsStop { get; set; }
        public Nullable<decimal> SalePlanID { get; set; }
    }
}
