using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class nVipJfSet
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> Jf { get; set; }
        public string Comment { get; set; }
        public Nullable<System.DateTime> TimeValue { get; set; }
    }
}
