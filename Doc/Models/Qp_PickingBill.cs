using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Qp_PickingBill
    {
        public decimal BillNumberId { get; set; }
        public int ID { get; set; }
        public int ReceptionBillId { get; set; }
        public string KTypeID { get; set; }
        public string CargoSpace { get; set; }
        public string PTypeID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> BackQty { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> InputCostPrice { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<int> Insurance { get; set; }
        public Nullable<int> IsUnit2 { get; set; }
        public string Comment { get; set; }
        public Nullable<int> HandZeroCost { get; set; }
    }
}
