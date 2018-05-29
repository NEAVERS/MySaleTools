using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class BaseInfoAssitDetection
    {
        public int Id { get; set; }
        public string BaseinfoType { get; set; }
        public string TableName { get; set; }
        public string TableColumnname { get; set; }
        public bool IfCategory { get; set; }
        public bool IfDelete { get; set; }
        public bool IfMove { get; set; }
        public bool IfUsed { get; set; }
        public string Explain { get; set; }
        public string Conditions { get; set; }
    }
}
