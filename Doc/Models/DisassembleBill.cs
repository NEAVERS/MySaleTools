using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class DisassembleBill
    {
        public decimal BillNumberId { get; set; }
        public string PtypeId { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> costprice { get; set; }
        public string jobnumber { get; set; }
        public Nullable<decimal> total { get; set; }
        public string inorout { get; set; }
        public Nullable<System.DateTime> outfactorydate { get; set; }
        public string comment { get; set; }
        public Nullable<int> goodsno { get; set; }
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
        public string KTypeID { get; set; }
        public string Stypeid { get; set; }
        public Nullable<decimal> NQty { get; set; }
        public Nullable<decimal> UnitRate { get; set; }
        public Nullable<int> CargoID { get; set; }
        public Nullable<long> ItemID { get; set; }
        public Nullable<int> IsCombined { get; set; }
        public int MUnitId { get; set; }
        public Nullable<decimal> MUnitRate { get; set; }
        public Nullable<decimal> MQty { get; set; }
        public Nullable<decimal> CurMSalePrice { get; set; }
        public Nullable<int> ShowOrder { get; set; }
        public int IsUnit2 { get; set; }
    }
}
