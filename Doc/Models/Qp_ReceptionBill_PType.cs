using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Qp_ReceptionBill_PType
    {
        public decimal BillNumberId { get; set; }
        public int ID { get; set; }
        public string PTypeID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> DiscountPrice { get; set; }
        public Nullable<decimal> DiscountTotal { get; set; }
        public Nullable<int> Insurance { get; set; }
        public string Comment { get; set; }
        public Nullable<int> Virtual { get; set; }
    }
}
