using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Sms_SendPlan
    {
        public int PlanID { get; set; }
        public string Phones { get; set; }
        public string QryCode { get; set; }
        public string QryParam { get; set; }
        public string SendTime { get; set; }
        public int RuleID { get; set; }
        public int State { get; set; }
    }
}
