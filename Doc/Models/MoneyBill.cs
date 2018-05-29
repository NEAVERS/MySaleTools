using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class MoneyBill
    {
        public decimal BillNumberId { get; set; }
        public string AtypeId { get; set; }
        public Nullable<decimal> total { get; set; }
        public string Comment { get; set; }
        public Nullable<int> TeamNo { get; set; }
        public Nullable<int> TeamNo1 { get; set; }
        public int ID { get; set; }
        public string Stypeid { get; set; }
        public Nullable<decimal> NTotal { get; set; }
        public string DTypeId { get; set; }
        public string ETypeId { get; set; }
        public Nullable<int> ShowOrder { get; set; }
    }
}
