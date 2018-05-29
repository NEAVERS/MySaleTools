using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class QP_RecycleBill
    {
        public decimal BillNumberId { get; set; }
        public int ID { get; set; }
        public string PTypeID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> total { get; set; }
        public string Comment { get; set; }
        public Nullable<int> Status { get; set; }
        public string Stypeid { get; set; }
    }
}
