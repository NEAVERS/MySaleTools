using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ShareSourceBill
    {
        public decimal BillNumberId { get; set; }
        public int BillType { get; set; }
        public decimal FromBillNumberID { get; set; }
        public decimal FromBillID { get; set; }
        public int FromBillType { get; set; }
        public int ID { get; set; }
        public Nullable<decimal> ShareFee { get; set; }
        public string Comment { get; set; }
        public Nullable<int> ShowOrder { get; set; }
    }
}
