using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Sms_AlarmSendRule
    {
        public int RuleID { get; set; }
        public Nullable<int> VchType { get; set; }
        public string RuleName { get; set; }
        public string Phones { get; set; }
        public Nullable<decimal> AlarmNum { get; set; }
        public Nullable<int> AlarmType { get; set; }
        public Nullable<int> SendCount { get; set; }
    }
}
