using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Qp_AttemperBill_RepairItemsPerson
    {
        public decimal BillNumberId { get; set; }
        public int ID { get; set; }
        public Nullable<int> RepairItemsID { get; set; }
        public string ETypeId { get; set; }
        public Nullable<System.DateTime> AllocateDate { get; set; }
        public Nullable<decimal> AllocateHour { get; set; }
        public Nullable<decimal> CheckHour { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> CostTotal { get; set; }
    }
}
