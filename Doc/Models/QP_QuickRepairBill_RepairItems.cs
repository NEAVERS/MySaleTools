using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class QP_QuickRepairBill_RepairItems
    {
        public decimal BillNumberId { get; set; }
        public int ID { get; set; }
        public string RepairItemsTypeID { get; set; }
        public Nullable<decimal> StandardManHour { get; set; }
        public Nullable<decimal> CheckHour { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> DiscountTotal { get; set; }
        public string RepairManTypeID { get; set; }
        public string Comment { get; set; }
        public int Insurance { get; set; }
        public Nullable<decimal> CostTotal { get; set; }
        public int Limited { get; set; }
        public string Stypeid { get; set; }
        public Nullable<int> CounterClaimStatus { get; set; }
    }
}
