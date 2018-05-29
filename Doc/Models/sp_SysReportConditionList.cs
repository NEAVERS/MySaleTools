using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class sp_SysReportConditionList
    {
        public int Id { get; set; }
        public string funName { get; set; }
        public string funExplain { get; set; }
        public string funExample { get; set; }
        public string paramExplain { get; set; }
        public Nullable<int> paramCount { get; set; }
    }
}
