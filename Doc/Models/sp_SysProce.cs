using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class sp_SysProce
    {
        public int ID { get; set; }
        public Nullable<int> sp_ReportId { get; set; }
        public string sp_ReportName { get; set; }
        public string sp_ProcName { get; set; }
        public Nullable<int> is_Tree { get; set; }
        public string hidd_Value { get; set; }
        public string onClick { get; set; }
        public string onDbClick { get; set; }
        public string Height { get; set; }
        public string Width { get; set; }
    }
}
