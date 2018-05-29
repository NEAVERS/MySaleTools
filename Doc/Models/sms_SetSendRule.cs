using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class sms_SetSendRule
    {
        public int RuleID { get; set; }
        public string RuleName { get; set; }
        public Nullable<int> CodeID { get; set; }
        public string Phones { get; set; }
        public string QryParam { get; set; }
        public string BeginDate { get; set; }
        public string EndDate { get; set; }
        public Nullable<int> TimeMode { get; set; }
        public Nullable<int> Interval { get; set; }
        public string Weeks { get; set; }
        public Nullable<int> SendCount { get; set; }
        public string SendTime { get; set; }
        public string CurrSend { get; set; }
    }
}
