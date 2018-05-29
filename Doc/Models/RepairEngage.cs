using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RepairEngage
    {
        public decimal BillNumberID { get; set; }
        public System.DateTime BillDate { get; set; }
        public string BillCode { get; set; }
        public int BillType { get; set; }
        public string PTypeID { get; set; }
        public string Serial { get; set; }
        public string ETypeID { get; set; }
        public string IfCheck { get; set; }
        public string Checke { get; set; }
        public Nullable<int> RedWord { get; set; }
        public Nullable<bool> Draft { get; set; }
        public Nullable<int> Stat { get; set; }
        public string ETypeID1 { get; set; }
        public Nullable<System.DateTime> RepairDate { get; set; }
        public string ETypeName1 { get; set; }
        public string Tel { get; set; }
        public Nullable<System.DateTime> BuyDate { get; set; }
        public string SaleBillID { get; set; }
        public string SaleBTypeName { get; set; }
        public string Buyer { get; set; }
        public string Address { get; set; }
        public string Brief { get; set; }
        public string Config { get; set; }
        public Nullable<int> RepairType { get; set; }
        public string Attach { get; set; }
        public string Fault { get; set; }
        public string Comment { get; set; }
    }
}
