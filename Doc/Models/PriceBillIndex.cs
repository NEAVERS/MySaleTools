using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PriceBillIndex
    {
        public decimal ID { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public int CID { get; set; }
        public byte IsFreePrice { get; set; }
        public byte IsUnitPrice { get; set; }
        public byte IsDiscount { get; set; }
        public byte IsRate { get; set; }
        public string Explain { get; set; }
        public string Comment { get; set; }
        public int BillType { get; set; }
        public Nullable<int> State { get; set; }
        public string Checke { get; set; }
        public Nullable<decimal> XiWaMaxNumber { get; set; }
        public byte[] PosDataVersion { get; set; }
    }
}
