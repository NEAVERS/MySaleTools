using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class vWeb_Pay
    {
        public decimal BillNumberId { get; set; }
        public string AtypeId { get; set; }
        public Nullable<decimal> total { get; set; }
        public string Comment { get; set; }
        public string FullName { get; set; }
        public string UserCode { get; set; }
        public int ID { get; set; }
    }
}
