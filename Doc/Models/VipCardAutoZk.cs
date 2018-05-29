using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class VipCardAutoZk
    {
        public int VipCardAutoID { get; set; }
        public Nullable<int> VipCardId { get; set; }
        public Nullable<decimal> ZkHighLimit { get; set; }
        public Nullable<decimal> ZkLowLimit { get; set; }
        public Nullable<decimal> ZkAutoRate { get; set; }
        public string Note { get; set; }
    }
}
