using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Userconfig
    {
        public int ConfigNo { get; set; }
        public string ConfigName { get; set; }
        public string Value { get; set; }
        public string EtypeId { get; set; }
        public string IsAll { get; set; }
    }
}
