using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class IndexChartData
    {
        public string TypeID { get; set; }
        public string FullName { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<decimal> Total1 { get; set; }
        public Nullable<decimal> Total2 { get; set; }
        public Nullable<int> flag { get; set; }
        public Nullable<int> CountType { get; set; }
    }
}
