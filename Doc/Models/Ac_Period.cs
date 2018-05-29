using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_Period
    {
        public int PeriodId { get; set; }
        public string FYear { get; set; }
        public string FMonth { get; set; }
        public Nullable<int> IsNature { get; set; }
        public Nullable<int> NatureCount { get; set; }
        public Nullable<int> FPeriod { get; set; }
        public Nullable<System.DateTime> FBegin { get; set; }
        public Nullable<System.DateTime> FEnd { get; set; }
        public Nullable<int> Deleted { get; set; }
        public int IsCurrent { get; set; }
        public int IsDynamic { get; set; }
    }
}
