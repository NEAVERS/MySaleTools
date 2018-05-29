using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OA_OnlineUser
    {
        public int ID { get; set; }
        public string ETypeID_UserTypeID { get; set; }
        public Nullable<System.DateTime> LatestConnectTime { get; set; }
        public Nullable<System.DateTime> LoginTime { get; set; }
        public string UserName { get; set; }
        public string IP { get; set; }
        public string Status { get; set; }
        public string IPLocal { get; set; }
    }
}
