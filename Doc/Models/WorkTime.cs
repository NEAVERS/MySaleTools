using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class WorkTime
    {
        public string STypeID { get; set; }
        public System.TimeSpan StartTime { get; set; }
        public System.TimeSpan EndTime { get; set; }
        public int LateTime { get; set; }
        public string WorkDay { get; set; }
    }
}
