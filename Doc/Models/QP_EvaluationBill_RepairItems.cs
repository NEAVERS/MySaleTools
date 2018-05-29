using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class QP_EvaluationBill_RepairItems
    {
        public decimal BillNumberId { get; set; }
        public int ID { get; set; }
        public string RepairItemsTypeID { get; set; }
        public Nullable<decimal> StandardManHour { get; set; }
        public Nullable<decimal> CheckHour { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string Stypeid { get; set; }
    }
}
