using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CommissionRule
    {
        public decimal BillNumberId { get; set; }
        public string BillCode { get; set; }
        public string FullName { get; set; }
        public System.DateTime BillDate { get; set; }
        public System.DateTime RuleStart { get; set; }
        public System.DateTime RuleEnd { get; set; }
        public int CommissionStandard { get; set; }
        public int IsUseEtypeCommission { get; set; }
        public int ECommissionType { get; set; }
        public int CommissionStyle { get; set; }
        public string Checke { get; set; }
        public string Checker { get; set; }
        public System.DateTime CheckeTime { get; set; }
        public Nullable<System.DateTime> CheckerTime { get; set; }
        public string Comment { get; set; }
        public int BillState { get; set; }
        public int UseState { get; set; }
        public int IsStop { get; set; }
    }
}
