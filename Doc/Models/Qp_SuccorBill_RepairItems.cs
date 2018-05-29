using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Qp_SuccorBill_RepairItems
    {
        public decimal BillNumberId { get; set; }
        public int ID { get; set; }
        public string RepairItemsTypeID { get; set; }
        public Nullable<decimal> StandardManHour { get; set; }
        public Nullable<decimal> CheckHour { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> CostTotal { get; set; }
        public string ETypeID { get; set; }
        public string Comment { get; set; }
    }
}
