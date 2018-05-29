using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class DiyIndex
    {
        public decimal BillNumberId { get; set; }
        public System.DateTime BillDate { get; set; }
        public string EtypeId { get; set; }
        public Nullable<decimal> ToTalQty { get; set; }
        public Nullable<decimal> TotalMoney { get; set; }
        public string Comment { get; set; }
        public string IndexOrderId { get; set; }
        public int Counts { get; set; }
        public string Checke { get; set; }
    }
}
