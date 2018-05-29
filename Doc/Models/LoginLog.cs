using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class LoginLog
    {
        public int id { get; set; }
        public Nullable<System.DateTime> LogTime { get; set; }
        public string comment { get; set; }
        public string beginloginmp { get; set; }
        public string endloginmp { get; set; }
        public string requeststamp { get; set; }
        public string getstamp { get; set; }
        public string finishstamp { get; set; }
        public Nullable<int> flag { get; set; }
        public Nullable<int> timecontrast { get; set; }
    }
}
