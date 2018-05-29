using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Sms_MessageRevice
    {
        public int ID { get; set; }
        public string PhoneNo { get; set; }
        public Nullable<System.DateTime> RecvTime { get; set; }
        public string Content { get; set; }
        public string SendID { get; set; }
        public Nullable<int> IfRead { get; set; }
    }
}
