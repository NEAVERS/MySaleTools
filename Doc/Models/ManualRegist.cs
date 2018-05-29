using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ManualRegist
    {
        public decimal Id { get; set; }
        public decimal AttendanceTimeId { get; set; }
        public System.TimeSpan RegistStartTime { get; set; }
        public System.TimeSpan RegistEndTime { get; set; }
        public string RegistReason { get; set; }
        public string etypeid { get; set; }
    }
}
