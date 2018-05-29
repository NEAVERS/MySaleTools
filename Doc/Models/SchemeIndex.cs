using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SchemeIndex
    {
        public decimal ID { get; set; }
        public string SchemeName { get; set; }
        public string SchemeExplain { get; set; }
        public int IsDefault { get; set; }
        public int RuleType { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string CreateID { get; set; }
    }
}
