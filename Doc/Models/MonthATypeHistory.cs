using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class MonthATypeHistory
    {
        public Nullable<int> period { get; set; }
        public string ATypeID { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> BqTotal { get; set; }
        public string Stypeid { get; set; }
        public Nullable<decimal> NTotal { get; set; }
        public Nullable<decimal> NBqTotal { get; set; }
        public Nullable<int> CID { get; set; }
    }
}
