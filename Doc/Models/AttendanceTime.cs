using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AttendanceTime
    {
        public decimal Id { get; set; }
        public string etypeid { get; set; }
        public System.DateTime date { get; set; }
        public System.TimeSpan StartTime { get; set; }
        public System.TimeSpan EndTime { get; set; }
        public int LeaveReasonID { get; set; }
        public string Comment { get; set; }
        public int Islate { get; set; }
    }
}
