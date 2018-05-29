using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PreBill
    {
        public decimal BillNumberId { get; set; }
        public int BillType { get; set; }
        public string Comment { get; set; }
        public string AtypeId { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<int> TeamNo { get; set; }
        public int ID { get; set; }
        public Nullable<int> TeamNO1 { get; set; }
        public string Stypeid { get; set; }
        public Nullable<decimal> ntotal { get; set; }
        public Nullable<int> ShowOrder { get; set; }
        public Nullable<int> vipcardid { get; set; }
        public Nullable<decimal> RelevanceBillId { get; set; }
    }
}
