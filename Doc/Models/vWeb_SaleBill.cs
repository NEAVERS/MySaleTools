using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class vWeb_SaleBill
    {
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public string Unit1 { get; set; }
        public string Unit2 { get; set; }
        public Nullable<decimal> UnitRate1 { get; set; }
        public Nullable<decimal> UnitRate2 { get; set; }
        public string EntryCode { get; set; }
        public string Standard { get; set; }
        public string Type { get; set; }
        public string Area { get; set; }
        public string IfSerial { get; set; }
        public Nullable<decimal> qty { get; set; }
        public Nullable<decimal> SalePrice { get; set; }
        public Nullable<decimal> TaxPrice { get; set; }
        public Nullable<decimal> TaxTotal { get; set; }
        public string comment { get; set; }
        public decimal BillNumberId { get; set; }
        public Nullable<int> OrderID { get; set; }
        public int ID { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> DiscountPrice { get; set; }
        public int isUnit2 { get; set; }
        public string Serial { get; set; }
    }
}
