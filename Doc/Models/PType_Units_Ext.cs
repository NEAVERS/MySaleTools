using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PType_Units_Ext
    {
        public string PtypeID { get; set; }
        public int UnitsId { get; set; }
        public int RateType { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public string EntryCode { get; set; }
        public int IsDefaultUnit { get; set; }
        public Nullable<int> IsUse { get; set; }
    }
}
