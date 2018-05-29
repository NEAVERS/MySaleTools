using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CM_FeeBill
    {
        public decimal BillNumberId { get; set; }
        public int ID { get; set; }
        public string Comment { get; set; }
        public int FeetypeId { get; set; }
        public Nullable<decimal> Total { get; set; }
    }
}
