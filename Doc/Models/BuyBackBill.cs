using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class BuyBackBill
    {
        public decimal BillNumberId { get; set; }
        public string PtypeId { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> SalePrice { get; set; }
        public Nullable<decimal> discount { get; set; }
        public Nullable<decimal> DiscountPrice { get; set; }
        public Nullable<decimal> costprice { get; set; }
        public string jobnumber { get; set; }
        public Nullable<int> goodsno { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<System.DateTime> OutFactoryDate { get; set; }
        public Nullable<decimal> TaxPrice { get; set; }
        public Nullable<decimal> TaxTotal { get; set; }
        public string comment { get; set; }
        public Nullable<int> TeamNo { get; set; }
        public Nullable<int> TeamNo1 { get; set; }
        public int ID { get; set; }
        public int IsUnit2 { get; set; }
        public string Serial { get; set; }
        public string OldID { get; set; }
        public Nullable<decimal> OldBillNumberID { get; set; }
        public Nullable<decimal> InputCostPrice { get; set; }
        public Nullable<int> GoodsOrder { get; set; }
        public string GoodsNumber { get; set; }
        public string ProduceDate { get; set; }
        public string ValidDate { get; set; }
        public string GoodsBTypeID { get; set; }
        public Nullable<decimal> GoodsCostPrice { get; set; }
        public Nullable<decimal> GoodsCostTotal { get; set; }
        public Nullable<int> HandZeroCost { get; set; }
        public Nullable<decimal> CompleteQTY { get; set; }
        public Nullable<decimal> SaleTotal { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public string KTypeID { get; set; }
        public string Stypeid { get; set; }
        public Nullable<decimal> TaxMoney { get; set; }
        public Nullable<decimal> NSalePrice { get; set; }
        public Nullable<decimal> NSaleTotal { get; set; }
        public Nullable<decimal> NDiscountPrice { get; set; }
        public Nullable<decimal> NTotal { get; set; }
        public Nullable<decimal> NTaxPrice { get; set; }
        public Nullable<decimal> NTaxTotal { get; set; }
        public Nullable<decimal> NTaxMoney { get; set; }
        public Nullable<int> UnitID { get; set; }
        public Nullable<int> NUnitID { get; set; }
        public Nullable<decimal> NQty { get; set; }
        public Nullable<decimal> UnitRate { get; set; }
        public string NUnitMsg { get; set; }
        public Nullable<int> MUnitID { get; set; }
        public Nullable<decimal> MQty { get; set; }
        public Nullable<decimal> MUnitRate { get; set; }
        public string MUnitMsg { get; set; }
        public Nullable<decimal> MSalePrice { get; set; }
        public Nullable<decimal> MDiscountPrice { get; set; }
        public Nullable<decimal> MTaxPrice { get; set; }
        public Nullable<decimal> CurMSalePrice { get; set; }
        public Nullable<decimal> CurMDiscountPrice { get; set; }
        public Nullable<decimal> CurMTaxPrice { get; set; }
        public Nullable<int> CargoID { get; set; }
        public Nullable<long> ItemID { get; set; }
        public Nullable<int> IsCombined { get; set; }
        public Nullable<decimal> InvoiceQty { get; set; }
        public Nullable<decimal> InvoiceMoney { get; set; }
        public Nullable<decimal> NInvoiceMoney { get; set; }
        public int IsGift { get; set; }
        public int PriceStyle { get; set; }
        public Nullable<int> ShowOrder { get; set; }
        public Nullable<decimal> CompleteTotal { get; set; }
        public Nullable<decimal> NCompleteTotal { get; set; }
    }
}
