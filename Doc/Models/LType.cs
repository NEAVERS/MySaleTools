using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class LType
    {
        public string TypeID { get; set; }
        public string ParID { get; set; }
        public short Leveal { get; set; }
        public int SonNum { get; set; }
        public int SonCount { get; set; }
        public string KTypeID { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public bool SysFlag { get; set; }
        public bool Deleted { get; set; }
        public string Comment { get; set; }
        public string PyCode { get; set; }
    }
}
