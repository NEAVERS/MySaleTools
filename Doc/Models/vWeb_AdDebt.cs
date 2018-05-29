using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class vWeb_AdDebt
    {
        public decimal BillNumberId { get; set; }
        public string Comment { get; set; }
        public string BtypeId { get; set; }
        public Nullable<decimal> total { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public int ID { get; set; }
    }
}
