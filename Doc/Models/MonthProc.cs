using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class MonthProc
    {
        public string MonthNo { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> period { get; set; }
        public string comment { get; set; }
    }
}
