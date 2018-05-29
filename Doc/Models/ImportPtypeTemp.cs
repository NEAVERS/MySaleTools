using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ImportPtypeTemp
    {
        public string etypeid { get; set; }
        public string BillType { get; set; }
        public string PtypeId { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public string StrEntryCode { get; set; }
        public string StrPrice { get; set; }
        public string StrTax { get; set; }
        public string StrDiscount { get; set; }
        public string munitid { get; set; }
        public string munit { get; set; }
        public string baseunitid { get; set; }
        public string baseunit { get; set; }
        public string nunitid { get; set; }
        public string nunit { get; set; }
        public string munitrate { get; set; }
        public string unitrate { get; set; }
        public string unitstype { get; set; }
        public Nullable<bool> deleted { get; set; }
        public Nullable<System.DateTime> ImportTime { get; set; }
        public string stockid { get; set; }
        public string stockname { get; set; }
        public string cargoid { get; set; }
        public string cargoName { get; set; }
        public string ProduceDate { get; set; }
        public string ValidDate { get; set; }
        public string GoodsNumber { get; set; }
        public string Comment { get; set; }
        public Nullable<int> IsService { get; set; }
        public Nullable<decimal> ReferPrice { get; set; }
        public string unitsentrycode { get; set; }
    }
}
