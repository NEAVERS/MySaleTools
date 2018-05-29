using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Report
    {
        public int reportId { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string path { get; set; }
        public int serverdbId { get; set; }
    }
}
