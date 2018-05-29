using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class QuotePriceBill
    {
        public int BillNumberID { get; set; }
        public int ID { get; set; }
        public string PTypeID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public int IsUnit2 { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> SaleTotal { get; set; }
        public Nullable<decimal> DiscountPrice { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public Nullable<decimal> TaxPrice { get; set; }
        public Nullable<decimal> TaxTotal { get; set; }
        public string Comment { get; set; }
        public string Stypeid { get; set; }
        public Nullable<decimal> CurRate { get; set; }
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
        public Nullable<decimal> ExpectedInterest { get; set; }
        public Nullable<decimal> ExpectedInterestRate { get; set; }
        public Nullable<int> ShowOrder { get; set; }
    }
}
