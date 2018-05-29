using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ColumnsField
    {
        public decimal ID { get; set; }
        public string DataField { get; set; }
        public string Fullname { get; set; }
        public Nullable<decimal> ShowOrder { get; set; }
        public string ReportName { get; set; }
    }
}
