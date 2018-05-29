using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AdDebtBill
    {
        public decimal BillNumberId { get; set; }
        public string Comment { get; set; }
        public string BtypeId { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<int> TeamNo { get; set; }
        public int ID { get; set; }
        public Nullable<int> TeamNO1 { get; set; }
        public Nullable<decimal> CompleteTotal { get; set; }
        public string Stypeid { get; set; }
        public Nullable<decimal> NTotal { get; set; }
        public Nullable<decimal> NCompleteTotal { get; set; }
        public Nullable<int> ShowOrder { get; set; }
        public int AlertDay { get; set; }
        public bool IfStopMoney { get; set; }
        public decimal ChargeOffTotal { get; set; }
        public Nullable<decimal> NChargeOffTotal { get; set; }
    }
}
