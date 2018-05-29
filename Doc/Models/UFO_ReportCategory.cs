using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class UFO_ReportCategory
    {
        public int ID { get; set; }
        public string TypeId { get; set; }
        public string Name { get; set; }
        public string ParentTypeId { get; set; }
        public Nullable<int> SysType { get; set; }
        public Nullable<int> IsShares { get; set; }
        public string etypeid { get; set; }
    }
}
