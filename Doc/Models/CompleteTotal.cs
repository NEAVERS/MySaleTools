using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CompleteTotal
    {
        public int GoodsBillID { get; set; }
        public int MoneyBillID { get; set; }
        public Nullable<decimal> CompleteTotal1 { get; set; }
        public int ID { get; set; }
        public Nullable<byte> Draft { get; set; }
        public Nullable<System.DateTime> Billdate { get; set; }
        public string EtypeID { get; set; }
        public Nullable<decimal> NCompleteTotal { get; set; }
        public Nullable<int> GoodsBillDetailID { get; set; }
        public Nullable<bool> IsSelect { get; set; }
        public Nullable<int> BillType { get; set; }
    }
}
