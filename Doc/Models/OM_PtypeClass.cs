using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OM_PtypeClass
    {
        public string TypeID { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public string ParID { get; set; }
        public Nullable<int> Leveal { get; set; }
        public Nullable<int> Sonnum { get; set; }
        public Nullable<int> Soncount { get; set; }
        public string Remark { get; set; }
    }
}
