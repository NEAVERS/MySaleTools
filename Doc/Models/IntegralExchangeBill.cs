using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class IntegralExchangeBill
    {
        public decimal BillNumberId { get; set; }
        public int ID { get; set; }
        public string KTypeID { get; set; }
        public string PTypeID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> total { get; set; }
        public string Comment { get; set; }
        public int IsUnit2 { get; set; }
        public Nullable<decimal> InputCostPrice { get; set; }
        public Nullable<decimal> GoodsCostPrice { get; set; }
        public Nullable<decimal> GoodsCostTotal { get; set; }
        public int HandZeroCost { get; set; }
        public string Stypeid { get; set; }
        public string Serial { get; set; }
        public string GoodsNumber { get; set; }
        public string ProduceDate { get; set; }
        public string ValidDate { get; set; }
        public Nullable<decimal> NQty { get; set; }
        public Nullable<decimal> UnitRate { get; set; }
        public Nullable<int> CargoID { get; set; }
        public Nullable<long> ItemID { get; set; }
        public Nullable<int> IsCombined { get; set; }
        public Nullable<int> ShowOrder { get; set; }
    }
}
