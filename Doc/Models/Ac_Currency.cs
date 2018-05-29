using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_Currency
    {
        public int CId { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<int> BasisType { get; set; }
        public string PyCode { get; set; }
        public Nullable<int> Deleted { get; set; }
        public int Sysrow { get; set; }
    }
}
