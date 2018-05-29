using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PromotePrice
    {
        public int PromoteId { get; set; }
        public string PtypeId { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<decimal> PromotePrice1 { get; set; }
        public string EtypeId { get; set; }
        public Nullable<System.DateTime> WriteDate { get; set; }
        public string BtypeId { get; set; }
        public string KtypeId { get; set; }
    }
}
