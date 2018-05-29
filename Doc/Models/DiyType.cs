using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class DiyType
    {
        public string typeId { get; set; }
        public string ParId { get; set; }
        public short leveal { get; set; }
        public int sonnum { get; set; }
        public int soncount { get; set; }
        public bool deleted { get; set; }
        public string TypeNumber { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
        public Nullable<int> IsSys { get; set; }
    }
}
