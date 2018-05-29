using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class sms_log
    {
        public int LogID { get; set; }
        public Nullable<int> nType { get; set; }
        public string MOBIL { get; set; }
        public string OperID { get; set; }
        public System.DateTime SendTime { get; set; }
        public string Content { get; set; }
        public string SendId { get; set; }
        public Nullable<int> Deleted { get; set; }
    }
}
