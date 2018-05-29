using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Msg_MessageList
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> MessageDate { get; set; }
        public string Comment { get; set; }
        public string SendEmployeeID { get; set; }
        public string SendEmployeeName { get; set; }
        public string GetEmployeeID { get; set; }
        public string GetEmployeeName { get; set; }
        public bool IsRead { get; set; }
        public bool IsSendDelete { get; set; }
        public bool IsGetDelete { get; set; }
    }
}
