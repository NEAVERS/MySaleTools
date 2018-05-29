using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class InOutstocktable
    {
        public decimal BillNumberId { get; set; }
        public Nullable<System.DateTime> BillDate { get; set; }
        public decimal BillType { get; set; }
        public string AtypeId { get; set; }
        public string PtypeId { get; set; }
        public string BtypeId { get; set; }
        public string EtypeId { get; set; }
        public string KtypeId { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> CostPrice { get; set; }
        public Nullable<decimal> CostTotal { get; set; }
        public string JobNumber { get; set; }
        public Nullable<int> GoodsNo { get; set; }
        public Nullable<System.DateTime> OutFactoryDate { get; set; }
        public bool Audited { get; set; }
        public string GoodsNumber { get; set; }
        public string ProduceDate { get; set; }
        public string ValidDate { get; set; }
        public string GoodsBTypeID { get; set; }
        public Nullable<decimal> GoodsCostPrice { get; set; }
        public Nullable<int> HandZeroCost { get; set; }
        public Nullable<int> ID { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> SalePrice { get; set; }
        public Nullable<decimal> SaleTotal { get; set; }
        public Nullable<decimal> TaxPrice { get; set; }
        public Nullable<decimal> TaxTotal { get; set; }
        public string DTypeID { get; set; }
        public string STypeID { get; set; }
        public Nullable<System.DateTime> PostTime { get; set; }
        public long SortID { get; set; }
        public Nullable<decimal> ShareFee { get; set; }
        public Nullable<int> CargoID { get; set; }
        public Nullable<decimal> NPrice { get; set; }
        public Nullable<decimal> NTotal { get; set; }
        public Nullable<decimal> NSalePrice { get; set; }
        public Nullable<decimal> NSaleTotal { get; set; }
        public Nullable<decimal> NTaxPrice { get; set; }
        public Nullable<decimal> NTaxTotal { get; set; }
        public int ItemID { get; set; }
        public bool IsCombined { get; set; }
        public Nullable<decimal> NQty { get; set; }
        public Nullable<decimal> UnitRate { get; set; }
        public Nullable<int> MUNITID { get; set; }
        public int IsGift { get; set; }
        public int IsService { get; set; }
        public Nullable<decimal> MUnitRate { get; set; }
        public string Comment { get; set; }
    }
}
