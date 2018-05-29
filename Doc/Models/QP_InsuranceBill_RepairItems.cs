using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class QP_InsuranceBill_RepairItems
    {
        public decimal BillNumberId { get; set; }
        public int ID { get; set; }
        public string RepairItemsTypeID { get; set; }
        public Nullable<decimal> ManHour { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> InsuranceTotal { get; set; }
        public Nullable<decimal> CostTotal { get; set; }
        public int Virtual { get; set; }
        public string Comment { get; set; }
        public string Stypeid { get; set; }
        public Nullable<int> QuickOrReceptionBillId { get; set; }
    }
}
