using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Qp_ReceptionBill_RepairItems
    {
        public decimal BillNumberId { get; set; }
        public int ID { get; set; }
        public string RepairItemsTypeID { get; set; }
        public Nullable<decimal> StandardManHour { get; set; }
        public Nullable<decimal> CheckHour { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> CostTotal { get; set; }
        public Nullable<int> RepairProcess { get; set; }
        public string StopReason { get; set; }
        public string RepairMan { get; set; }
        public Nullable<System.DateTime> StopTime { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> DiscountTotal { get; set; }
        public Nullable<int> Insurance { get; set; }
        public string Comment { get; set; }
        public Nullable<int> Virtual { get; set; }
        public Nullable<System.DateTime> AppointTime { get; set; }
        public Nullable<int> Limited { get; set; }
        public Nullable<int> CounterClaimStatus { get; set; }
    }
}
