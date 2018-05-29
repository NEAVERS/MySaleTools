using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class BalanceFile
    {
        public int ID { get; set; }
        public string FileName { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string FileSize { get; set; }
        public string EtypeID { get; set; }
        public string FileContent { get; set; }
        public string ZwCode { get; set; }
        public Nullable<int> Status { get; set; }
        public string TempleName { get; set; }
        public string TempleEtypeID { get; set; }
        public Nullable<System.DateTime> TempleTime { get; set; }
        public string CodeLength { get; set; }
        public Nullable<int> Is100 { get; set; }
    }
}
