using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CompleteGoodTotal
    {
        public int ID { get; set; }
        public int GoodsBillID { get; set; }
        public int MoneyBillID { get; set; }
        public string InOrOut { get; set; }
        public Nullable<decimal> CompleteGoodQTY { get; set; }
        public Nullable<byte> Draft { get; set; }
        public Nullable<System.DateTime> Billdate { get; set; }
        public string PtypeID { get; set; }
        public Nullable<int> Billid { get; set; }
        public Nullable<decimal> CompleteGoodTotal1 { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> NCompleteGoodTotal { get; set; }
        public Nullable<bool> IsSelect { get; set; }
        public Nullable<int> BillType { get; set; }
    }
}
