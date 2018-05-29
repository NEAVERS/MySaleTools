using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Msg_Online
    {
        public int ID { get; set; }
        public string ConnectID { get; set; }
        public Nullable<System.DateTime> LatestConnectTime { get; set; }
        public Nullable<System.DateTime> LoginTime { get; set; }
        public string UserName { get; set; }
        public string Unit { get; set; }
        public string IP { get; set; }
        public string State { get; set; }
    }
}
