using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CommissionBillNew
    {
        public decimal BillNumberId { get; set; }
        public string BillCode { get; set; }
        public System.DateTime BillDate { get; set; }
        public Nullable<System.DateTime> CommissionStart { get; set; }
        public Nullable<System.DateTime> CommissionEnd { get; set; }
        public decimal CommissionSchemeID { get; set; }
        public Nullable<int> CommissionType { get; set; }
        public string Checke { get; set; }
        public string Checker { get; set; }
        public System.DateTime CheckeTime { get; set; }
        public Nullable<System.DateTime> CheckerTime { get; set; }
        public string Explain { get; set; }
        public string Comment { get; set; }
        public int IsAuto { get; set; }
        public int BillState { get; set; }
        public string ifcheck { get; set; }
        public Nullable<bool> draft { get; set; }
        public string StypeID { get; set; }
        public Nullable<int> RedWord { get; set; }
        public string Poster { get; set; }
        public Nullable<System.DateTime> PostTime { get; set; }
        public Nullable<decimal> CommissionTotal { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> qty { get; set; }
        public string FChecker { get; set; }
        public Nullable<System.DateTime> FCheckerTime { get; set; }
        public string FPoster { get; set; }
        public Nullable<System.DateTime> FPostTime { get; set; }
        public Nullable<int> atid { get; set; }
        public Nullable<decimal> billtype { get; set; }
    }
}
