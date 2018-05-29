using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OrderBill
    {
        public decimal billNumberID { get; set; }
        public string ptypeid { get; set; }
        public Nullable<decimal> qty { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<decimal> ReachQty { get; set; }
        public string comment { get; set; }
        public int OrderID { get; set; }
        public bool Checked { get; set; }
        public Nullable<int> TeamNO1 { get; set; }
        public Nullable<decimal> PassQty { get; set; }
        public bool IsUnit2 { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> DiscountPrice { get; set; }
        public Nullable<decimal> TaxPrice { get; set; }
        public Nullable<decimal> TaxTotal { get; set; }
        public Nullable<decimal> SaleTotal { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public string KTypeID { get; set; }
        public string Stypeid { get; set; }
        public Nullable<decimal> FromBillNumberID { get; set; }
        public string entrycode { get; set; }
        public Nullable<decimal> FromBillID { get; set; }
        public Nullable<decimal> ReachTotal { get; set; }
        public Nullable<decimal> ReachTaxTotal { get; set; }
        public Nullable<decimal> RequestBillNumberID { get; set; }
        public Nullable<decimal> RequestBillID { get; set; }
        public Nullable<decimal> AskBillNumberID { get; set; }
        public Nullable<decimal> AskBillID { get; set; }
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
        public Nullable<long> ItemID { get; set; }
        public Nullable<int> IsCombined { get; set; }
        public Nullable<decimal> GoodsCostPrice { get; set; }
        public Nullable<int> GoodsOrder { get; set; }
        public string ProduceDate { get; set; }
        public string ValidDate { get; set; }
        public int IsGift { get; set; }
        public string YapiID { get; set; }
        public string PriceSource { get; set; }
        public int Id { get; set; }
        public int PromoType { get; set; }
        public Nullable<int> ShowOrder { get; set; }
        public Nullable<decimal> WaitQty { get; set; }
        public Nullable<bool> BillOver { get; set; }
        public string GoodsNumber { get; set; }
        public Nullable<int> CargoID { get; set; }
        public string stopreason { get; set; }
    }
}
