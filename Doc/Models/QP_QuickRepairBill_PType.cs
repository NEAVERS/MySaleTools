using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class QP_QuickRepairBill_PType
    {
        public decimal BillNumberId { get; set; }
        public int ID { get; set; }
        public string KTypeID { get; set; }
        public string CargoSpace { get; set; }
        public string PTypeID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> DiscountPrice { get; set; }
        public Nullable<decimal> DiscountTotal { get; set; }
        public string RepairManTypeID { get; set; }
        public string Comment { get; set; }
        public int IsUnit2 { get; set; }
        public Nullable<decimal> InputCostPrice { get; set; }
        public Nullable<decimal> GoodsCostPrice { get; set; }
        public Nullable<decimal> GoodsCostTotal { get; set; }
        public int HandZeroCost { get; set; }
        public int Insurance { get; set; }
        public string Stypeid { get; set; }
        public Nullable<int> CounterClaimStatus { get; set; }
    }
}
