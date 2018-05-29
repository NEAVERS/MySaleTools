using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class sms_QueryCode_Set
    {
        public int CodeID { get; set; }
        public string QryCode { get; set; }
        public string VERSION { get; set; }
        public string QRYNAME { get; set; }
        public string PROCNAME { get; set; }
        public string Params { get; set; }
        public Nullable<int> STATE { get; set; }
        public string CONTENT { get; set; }
        public string Comment { get; set; }
    }
}
