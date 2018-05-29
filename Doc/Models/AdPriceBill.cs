using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AdPriceBill
    {
        public decimal BillNumberId { get; set; }
        public string Comment { get; set; }
        public string PtypeId { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> BeforePrice { get; set; }
        public Nullable<decimal> BeforeTotal { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> total { get; set; }
        public string JobNumber { get; set; }
        public Nullable<int> GoodsNo { get; set; }
        public Nullable<System.DateTime> OutFactoryDate { get; set; }
        public int IsUnit2 { get; set; }
        public int ID { get; set; }
        public Nullable<int> ChangeAllStock { get; set; }
        public Nullable<decimal> InputCostPrice { get; set; }
        public Nullable<int> GoodsOrder { get; set; }
        public string GoodsNumber { get; set; }
        public string ProduceDate { get; set; }
        public string ValidDate { get; set; }
        public string GoodsBTypeID { get; set; }
        public Nullable<decimal> GoodsCostPrice { get; set; }
        public Nullable<decimal> GoodsCostTotal { get; set; }
        public Nullable<int> HandZeroCost { get; set; }
        public string Stypeid { get; set; }
        public string ktypeid { get; set; }
        public string Serial { get; set; }
        public Nullable<decimal> NPrice { get; set; }
        public Nullable<decimal> NTotal { get; set; }
        public Nullable<int> FromBillNumberID { get; set; }
        public Nullable<int> FromBillType { get; set; }
        public Nullable<int> FromBillID { get; set; }
        public Nullable<int> ShowOrder { get; set; }
        public Nullable<decimal> ChangeTotal { get; set; }
        public Nullable<decimal> NQty { get; set; }
        public Nullable<decimal> UnitRate { get; set; }
        public Nullable<long> ItemID { get; set; }
        public Nullable<int> IsCombined { get; set; }
        public Nullable<int> cargoID { get; set; }
        public int Type { get; set; }
    }
}
