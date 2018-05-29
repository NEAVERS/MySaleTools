using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ChargeOffBill
    {
        public decimal BillNumberId { get; set; }
        public decimal FromBillNumberid { get; set; }
        public decimal FromBillType { get; set; }
        public Nullable<int> FromBillID { get; set; }
        public int ID { get; set; }
        public int ChargeOffType { get; set; }
        public byte IsCharged { get; set; }
        public string BTypeID { get; set; }
        public Nullable<decimal> ChargeOffValue { get; set; }
        public Nullable<decimal> NChargeOffValue { get; set; }
        public Nullable<int> TeamNo { get; set; }
        public string Comment { get; set; }
        public Nullable<int> ShowOrder { get; set; }
    }
}
