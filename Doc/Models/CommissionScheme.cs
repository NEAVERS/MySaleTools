using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CommissionScheme
    {
        public decimal BillNumberId { get; set; }
        public Nullable<System.DateTime> SchemeStart { get; set; }
        public Nullable<System.DateTime> SchemeEnd { get; set; }
        public string SchemeName { get; set; }
        public decimal CommissionRuleID { get; set; }
        public decimal ReferencePlanID { get; set; }
        public string Comment { get; set; }
        public string Checke { get; set; }
        public string Checker { get; set; }
        public System.DateTime CheckeTime { get; set; }
        public Nullable<System.DateTime> CheckerTime { get; set; }
        public int BillState { get; set; }
        public int UseState { get; set; }
        public int IsStop { get; set; }
    }
}
