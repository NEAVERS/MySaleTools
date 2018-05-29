using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SchemeDetail
    {
        public decimal nId { get; set; }
        public decimal SchemeId { get; set; }
        public string DataField { get; set; }
        public string DataValue { get; set; }
        public string DataText { get; set; }
        public string ControlType { get; set; }
        public string BaseType { get; set; }
    }
}
