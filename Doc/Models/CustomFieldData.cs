using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CustomFieldData
    {
        public int ID { get; set; }
        public string configKind { get; set; }
        public string profile { get; set; }
        public string userId { get; set; }
        public string elementId { get; set; }
        public string content { get; set; }
    }
}
