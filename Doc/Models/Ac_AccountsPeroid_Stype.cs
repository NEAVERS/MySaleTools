using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_AccountsPeroid_Stype
    {
        public int Id { get; set; }
        public string Stypeid { get; set; }
        public Nullable<int> FYear { get; set; }
        public Nullable<int> FPeriod { get; set; }
    }
}
