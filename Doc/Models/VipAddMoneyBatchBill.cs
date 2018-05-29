using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class VipAddMoneyBatchBill
    {
        public int BillNumberId { get; set; }
        public int Id { get; set; }
        public int VipCardId { get; set; }
        public Nullable<decimal> BeforeChargeMoney { get; set; }
        public Nullable<decimal> AfterChargeMoney { get; set; }
        public Nullable<decimal> ChargeMoney { get; set; }
        public Nullable<decimal> PreferenceMoney { get; set; }
        public Nullable<decimal> TotalInMoney { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Comment { get; set; }
        public Nullable<int> ShowOrder { get; set; }
    }
}
