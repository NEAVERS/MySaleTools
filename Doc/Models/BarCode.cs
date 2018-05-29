using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class BarCode
    {
        public int ID { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public bool Deleted { get; set; }
        public bool IsDefault { get; set; }
        public bool IsPrint { get; set; }
    }
}
