using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Qp_SuccorBill_SuccorItems
    {
        public decimal BillNumberId { get; set; }
        public int ID { get; set; }
        public Nullable<int> SuccorChargeId { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string Comment { get; set; }
    }
}
