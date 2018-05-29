using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class vWeb_OrderBillFromBill
    {
        public decimal billNumberId { get; set; }
        public string fhdw { get; set; }
        public int OrderID { get; set; }
        public Nullable<decimal> qty { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public Nullable<decimal> TaxPrice { get; set; }
        public Nullable<decimal> DiscountPrice { get; set; }
        public Nullable<decimal> TaxTotal { get; set; }
        public Nullable<decimal> BigQty { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<decimal> ReachQty { get; set; }
        public Nullable<decimal> PassQty { get; set; }
        public string ptypeid { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public string EntryCode { get; set; }
        public string Standard { get; set; }
        public string Type { get; set; }
        public string Area { get; set; }
        public string Unit1 { get; set; }
        public string Unit2 { get; set; }
        public Nullable<decimal> UnitRate1 { get; set; }
        public Nullable<decimal> UnitRate2 { get; set; }
        public string IfSerial { get; set; }
        public Nullable<int> serialcount { get; set; }
        public Nullable<int> validdays { get; set; }
        public string comment { get; set; }
        public string CustomerCode { get; set; }
        public Nullable<bool> IsUnit2 { get; set; }
    }
}
