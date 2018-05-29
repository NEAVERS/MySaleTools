using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Qp_SuccorBill_PType
    {
        public decimal BillNumberId { get; set; }
        public int ID { get; set; }
        public string PTypeID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string ETypeID { get; set; }
        public string Comment { get; set; }
        public Nullable<decimal> CostTotal { get; set; }
        public Nullable<decimal> InputCostPrice { get; set; }
        public string KTypeId { get; set; }
        public string CargoSpace { get; set; }
        public Nullable<int> HandZeroCost { get; set; }
    }
}
