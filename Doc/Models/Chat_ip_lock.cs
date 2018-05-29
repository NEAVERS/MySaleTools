using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Chat_ip_lock
    {
        public int ID { get; set; }
        public string ip { get; set; }
        public Nullable<System.DateTime> end_time { get; set; }
    }
}
