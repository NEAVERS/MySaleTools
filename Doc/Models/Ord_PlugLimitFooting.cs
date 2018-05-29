using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ord_PlugLimitFooting
    {
        public int Id { get; set; }
        public int plugid { get; set; }
        public int LimitId { get; set; }
        public string EtypeId { get; set; }
        public int Lim { get; set; }
    }
}
