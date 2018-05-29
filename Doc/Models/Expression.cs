using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Expression
    {
        public decimal ID { get; set; }
        public string EtypeID { get; set; }
        public string Sub { get; set; }
        public string SubName { get; set; }
        public string Comment { get; set; }
        public int ConstFlag { get; set; }
        public string HiddenSub { get; set; }
    }
}
