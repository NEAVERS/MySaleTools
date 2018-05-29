using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class vWeb_MoveBjBill
    {
        public string mcomment { get; set; }
        public decimal BillNumberId { get; set; }
        public string PtypeId { get; set; }
        public Nullable<decimal> qty { get; set; }
        public int IsUnit2 { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public string Unit1 { get; set; }
        public string Unit2 { get; set; }
        public Nullable<decimal> UnitRate1 { get; set; }
        public Nullable<decimal> UnitRate2 { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<decimal> total { get; set; }
        public int ID { get; set; }
        public string EntryCode { get; set; }
        public string Standard { get; set; }
        public string Type { get; set; }
        public string Area { get; set; }
        public string IfSerial { get; set; }
        public string Serial { get; set; }
    }
}
