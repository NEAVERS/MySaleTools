using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CommissionType
    {
        public decimal ID { get; set; }
        public string TypeID { get; set; }
        public string ParID { get; set; }
        public int Sonnum { get; set; }
        public string FullName { get; set; }
        public string EtypeID { get; set; }
        public int IsSystem { get; set; }
        public int SonCount { get; set; }
    }
}
