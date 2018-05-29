using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class frtype
    {
        public string typeId { get; set; }
        public string ParId { get; set; }
        public short leveal { get; set; }
        public int sonnum { get; set; }
        public int soncount { get; set; }
        public string UserCode { get; set; }
        public string FaultExplain { get; set; }
        public string FaultReason { get; set; }
        public Nullable<decimal> XiWaMaxNumber { get; set; }
    }
}
