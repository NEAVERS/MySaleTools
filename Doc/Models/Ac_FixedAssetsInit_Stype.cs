using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_FixedAssetsInit_Stype
    {
        public int Id { get; set; }
        public string StypeId { get; set; }
        public Nullable<int> FYear { get; set; }
        public Nullable<int> FPeriod { get; set; }
        public string EtypeId { get; set; }
        public Nullable<System.DateTime> InitDate { get; set; }
    }
}
