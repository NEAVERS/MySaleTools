using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class MoveMoneyBill
    {
        public decimal BillNumberId { get; set; }
        public string Comment { get; set; }
        public string AtypeId { get; set; }
        public Nullable<decimal> total { get; set; }
        public int ID { get; set; }
        public string Stypeid { get; set; }
        public Nullable<decimal> ntotal { get; set; }
        public Nullable<int> ShowOrder { get; set; }
    }
}
