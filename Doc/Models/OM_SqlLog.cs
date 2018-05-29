using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OM_SqlLog
    {
        public int ID { get; set; }
        public byte Type { get; set; }
        public System.DateTime DateTime { get; set; }
        public int Elapsed { get; set; }
        public string Params { get; set; }
        public string IPAddress { get; set; }
        public string C_Sql { get; set; }
        public Nullable<int> ExecuteElapsed { get; set; }
        public Nullable<int> FetchElapsed { get; set; }
        public Nullable<int> C_RowCount { get; set; }
        public string Error { get; set; }
        public int LoginUserID { get; set; }
    }
}
