using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class STypeMoveBill
    {
        public decimal BillNumberId { get; set; }
        public decimal BillType { get; set; }
        public string Comment { get; set; }
        public string PtypeId { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string Jobnumber { get; set; }
        public Nullable<int> GoodsNo { get; set; }
        public Nullable<System.DateTime> OutFactoryDate { get; set; }
        public int IsUnit2 { get; set; }
        public int ID { get; set; }
        public string Serial { get; set; }
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
        public string Ktypeid { get; set; }
        public string Ktypeid2 { get; set; }
        public Nullable<decimal> FromBillNumberID { get; set; }
        public Nullable<int> FromBillID { get; set; }
        public Nullable<int> UnitID { get; set; }
        public Nullable<int> NUnitID { get; set; }
        public Nullable<decimal> NQty { get; set; }
        public Nullable<decimal> UnitRate { get; set; }
        public string NUnitMsg { get; set; }
        public Nullable<int> MUnitID { get; set; }
        public Nullable<decimal> MQty { get; set; }
        public Nullable<decimal> MUnitRate { get; set; }
        public string MUnitMsg { get; set; }
        public Nullable<decimal> MPrice { get; set; }
        public Nullable<int> InCargoID { get; set; }
        public Nullable<int> OutCargoID { get; set; }
        public Nullable<long> ItemID { get; set; }
        public Nullable<int> IsCombined { get; set; }
        public Nullable<int> ShowOrder { get; set; }
    }
}
