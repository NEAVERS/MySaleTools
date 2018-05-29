using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class QP_RepairAutoType
    {
        public string TypeID { get; set; }
        public string ParID { get; set; }
        public int Leveal { get; set; }
        public int SonCount { get; set; }
        public int SonNum { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public Nullable<decimal> XiWaMaxNumber { get; set; }
        public string PYCode { get; set; }
    }
}
