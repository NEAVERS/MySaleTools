using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Advantage
    {
        public decimal BillNumberId { get; set; }
        public string Serial { get; set; }
        public string Ptypeid { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string StandardCode { get; set; }
        public int Type { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string comment { get; set; }
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
