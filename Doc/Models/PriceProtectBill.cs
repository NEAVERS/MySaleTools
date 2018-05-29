using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PriceProtectBill
    {
        public decimal BillNumberid { get; set; }
        public string Serial { get; set; }
        public string Ptypeid { get; set; }
        public Nullable<decimal> OldTotal { get; set; }
        public Nullable<decimal> OldPrice { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> NewPrice { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string Comment { get; set; }
        public int ID { get; set; }
        public Nullable<int> TeamNo { get; set; }
        public Nullable<int> TeamNo1 { get; set; }
        public Nullable<int> BillType { get; set; }
        public string Stypeid { get; set; }
        public Nullable<long> ItemID { get; set; }
        public Nullable<int> IsCombined { get; set; }
        public string GoodsNumber { get; set; }
    }
}
