using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Qp_ThreePacketsBill_RepairItems
    {
        public decimal BillNumberId { get; set; }
        public int ID { get; set; }
        public string RepairItemsTypeID { get; set; }
        public Nullable<decimal> StandardManHour { get; set; }
        public Nullable<decimal> RepairTotal { get; set; }
        public Nullable<decimal> InsuranceTotal { get; set; }
        public Nullable<decimal> CostTotal { get; set; }
        public string Comment { get; set; }
        public Nullable<int> QuickOrReceptionBillId { get; set; }
        public Nullable<int> Virtual { get; set; }
    }
}
