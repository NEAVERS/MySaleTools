using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Scheme
    {
        public decimal SchemeId { get; set; }
        public string ETypeID { get; set; }
        public string ReportName { get; set; }
        public string SchemeName { get; set; }
        public Nullable<int> IsDefault { get; set; }
        public string inputtype { get; set; }
    }
}
