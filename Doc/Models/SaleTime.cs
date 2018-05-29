using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SaleTime
    {
        public int ID { get; set; }
        public Nullable<int> TotalID { get; set; }
        public string PeriodTime { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public Nullable<int> Days { get; set; }
    }
}
