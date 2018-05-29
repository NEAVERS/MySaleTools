using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class vWeb_GiveBill
    {
        public string BillComment { get; set; }
        public decimal BillNumberID { get; set; }
        public string PTypeID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public int IsUnit2 { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public string Unit1 { get; set; }
        public string Unit2 { get; set; }
        public Nullable<decimal> UnitRate1 { get; set; }
        public Nullable<decimal> UnitRate2 { get; set; }
        public int ID { get; set; }
    }
}
