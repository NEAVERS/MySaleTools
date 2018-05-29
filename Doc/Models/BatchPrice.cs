using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class BatchPrice
    {
        public int id { get; set; }
        public string DepartId { get; set; }
        public string DepartUserCode { get; set; }
        public string DepartFullName { get; set; }
        public string PTypeId { get; set; }
        public string PUserCode { get; set; }
        public string PFullName { get; set; }
        public string PEntryCode { get; set; }
        public string PStandard { get; set; }
        public string PType { get; set; }
        public Nullable<decimal> PrePrice1 { get; set; }
        public Nullable<decimal> PrePrice2 { get; set; }
        public Nullable<decimal> PrePrice3 { get; set; }
        public Nullable<decimal> PrePrice4 { get; set; }
        public Nullable<decimal> recPrice { get; set; }
        public string Explain { get; set; }
        public Nullable<int> Default { get; set; }
    }
}
