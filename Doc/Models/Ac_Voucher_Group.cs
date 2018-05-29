using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_Voucher_Group
    {
        public int VgId { get; set; }
        public string FullName { get; set; }
        public Nullable<int> IsMulVourchLimit { get; set; }
        public string PyCode { get; set; }
        public int IsDefault { get; set; }
    }
}
