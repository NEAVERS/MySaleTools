using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ReceiptBill
    {
        public decimal BillNumberID { get; set; }
        public decimal BillType { get; set; }
        public Nullable<decimal> MainBillNumberID { get; set; }
        public string KTypeID { get; set; }
        public string PTypeID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public Nullable<decimal> TaxPrice { get; set; }
        public Nullable<decimal> TaxTotal { get; set; }
        public string Comment { get; set; }
        public int ID { get; set; }
        public string Stypeid { get; set; }
        public Nullable<decimal> discount { get; set; }
        public Nullable<decimal> BeforePrice { get; set; }
        public Nullable<decimal> BeforeTotal { get; set; }
        public int RecordedItemId { get; set; }
        public Nullable<decimal> Nprice { get; set; }
        public Nullable<decimal> NTotal { get; set; }
        public Nullable<decimal> NTaxPrice { get; set; }
        public Nullable<decimal> NTaxTotal { get; set; }
        public Nullable<decimal> NTaxMoney { get; set; }
        public Nullable<int> CargoID { get; set; }
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
        public Nullable<decimal> MTaxPrice { get; set; }
        public Nullable<decimal> CurMPrice { get; set; }
        public Nullable<decimal> CurMTaxPrice { get; set; }
        public Nullable<long> ItemID { get; set; }
        public Nullable<int> IsCombined { get; set; }
        public Nullable<decimal> Nbeforeprice { get; set; }
        public Nullable<decimal> NBeforeTotal { get; set; }
        public string goodsnumber { get; set; }
        public Nullable<decimal> saleprice { get; set; }
        public Nullable<decimal> saletotal { get; set; }
        public Nullable<decimal> nsaleprice { get; set; }
        public Nullable<decimal> nsaletotal { get; set; }
        public Nullable<decimal> curmsaleprice { get; set; }
        public Nullable<decimal> curmsaletotal { get; set; }
        public Nullable<decimal> taxmoney { get; set; }
        public Nullable<decimal> CompleteQty { get; set; }
        public Nullable<decimal> CompleteTotal { get; set; }
        public Nullable<decimal> NCompleteTotal { get; set; }
        public Nullable<int> IsGift { get; set; }
        public Nullable<int> TeamNo { get; set; }
        public Nullable<int> TeamNO1 { get; set; }
        public Nullable<decimal> InvoiceCostTotal { get; set; }
        public Nullable<int> MainBillType { get; set; }
        public Nullable<decimal> InvoiceCostPrice { get; set; }
        public string ProduceDate { get; set; }
        public string ValidDate { get; set; }
        public string Serial { get; set; }
        public Nullable<int> ShowOrder { get; set; }
    }
}
