using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CashMoneyBill
    {
        public decimal BillNumberId { get; set; }
        public string AtypeId { get; set; }
        public Nullable<decimal> total { get; set; }
        public string Comment { get; set; }
        public Nullable<int> TeamNo { get; set; }
        public Nullable<int> TeamNo1 { get; set; }
        public int ID { get; set; }
        public string Stypeid { get; set; }
    }
}
