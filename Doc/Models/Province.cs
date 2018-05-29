using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Province
    {
        public int id { get; set; }
        public string areacode { get; set; }
        public string areaname { get; set; }
        public string zaiyao { get; set; }
        public bool deleted { get; set; }
    }
}
