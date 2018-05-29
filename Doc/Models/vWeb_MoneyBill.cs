using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class vWeb_MoneyBill
    {
        public string BillComment { get; set; }
        public decimal BillNumberID { get; set; }
        public string ATypeID { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public int ID { get; set; }
    }
}
