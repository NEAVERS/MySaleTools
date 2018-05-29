using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_DepreciationPlan
    {
        public int Id { get; set; }
        public string STypeId { get; set; }
        public string DTypeid { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<System.DateTime> InAccountDate { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public Nullable<int> DepreciationMean { get; set; }
        public Nullable<int> YearOrder { get; set; }
        public Nullable<int> FYear { get; set; }
        public Nullable<int> MonthOrder { get; set; }
        public Nullable<int> PlanType { get; set; }
        public Nullable<int> AssetCardId { get; set; }
        public Nullable<decimal> Depreciation { get; set; }
        public Nullable<decimal> DepTotal { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> DevalueReady { get; set; }
        public Nullable<decimal> NetValue { get; set; }
        public Nullable<decimal> NetSalvage { get; set; }
        public Nullable<int> PlanState { get; set; }
        public Nullable<int> LocationId { get; set; }
        public string DisATypeId { get; set; }
        public Nullable<int> BillNumberId { get; set; }
        public Nullable<decimal> ExpectWork { get; set; }
        public Nullable<decimal> FinishWork { get; set; }
        public string WorkUnit { get; set; }
        public Nullable<int> FPeriod { get; set; }
    }
}
