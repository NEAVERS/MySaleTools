using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RepairDeal
    {
        public decimal BillNumberID { get; set; }
        public Nullable<decimal> EngageBillID { get; set; }
        public Nullable<System.DateTime> BillDate { get; set; }
        public string BillCode { get; set; }
        public Nullable<int> BillType { get; set; }
        public string PTypeID { get; set; }
        public string ETypeID { get; set; }
        public string IfCheck { get; set; }
        public string Checke { get; set; }
        public Nullable<int> RedWord { get; set; }
        public Nullable<bool> Draft { get; set; }
        public Nullable<int> Stat { get; set; }
        public string Fault { get; set; }
        public string Comment { get; set; }
        public Nullable<int> Method { get; set; }
        public string KTypeID1 { get; set; }
        public string KTypeID2 { get; set; }
        public Nullable<decimal> MoneyChange { get; set; }
        public Nullable<decimal> MoneyRepair { get; set; }
        public Nullable<decimal> TotalMoney { get; set; }
        public Nullable<decimal> TotalInMoney { get; set; }
        public string BTypeID { get; set; }
        public string ATypeID { get; set; }
        public string Brief { get; set; }
        public Nullable<bool> NotFree { get; set; }
        public string FreeMemo { get; set; }
        public string ETypeID1 { get; set; }
        public string ETypeID2 { get; set; }
        public Nullable<System.DateTime> PayDate { get; set; }
        public Nullable<bool> IfPay { get; set; }
        public string IDCard { get; set; }
        public Nullable<int> TeamNo { get; set; }
        public int ID { get; set; }
    }
}
