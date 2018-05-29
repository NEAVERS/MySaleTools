using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class GuestPay
    {
        public decimal BillNumberId { get; set; }
        public string AtypeId { get; set; }
        public Nullable<decimal> total { get; set; }
        public string Comment { get; set; }
        public Nullable<int> ID { get; set; }
        public Nullable<int> TeamNO1 { get; set; }
    }
}
