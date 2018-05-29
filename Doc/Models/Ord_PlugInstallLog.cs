using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ord_PlugInstallLog
    {
        public int id { get; set; }
        public string plugname { get; set; }
        public Nullable<int> plugid { get; set; }
        public string XmlContent { get; set; }
        public Nullable<System.DateTime> installdate { get; set; }
    }
}
