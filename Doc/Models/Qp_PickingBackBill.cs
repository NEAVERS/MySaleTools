using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Qp_PickingBackBill
    {
        public decimal BillNumberId { get; set; }
        public int ID { get; set; }
        public Nullable<int> PickingId { get; set; }
        public string KTypeId { get; set; }
        public string PTypeId { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> InputCostPrice { get; set; }
        public string CargoSpace { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<int> Insurance { get; set; }
        public string Comment { get; set; }
        public Nullable<int> IsUnit2 { get; set; }
        public Nullable<int> HandZeroCost { get; set; }
    }
}
