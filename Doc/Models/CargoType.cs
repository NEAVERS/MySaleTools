using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CargoType
    {
        public int CargoID { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public string KtypeID { get; set; }
        public string Comment { get; set; }
        public string PyCode { get; set; }
        public Nullable<int> deleted { get; set; }
        public int IsDefault { get; set; }
        public Nullable<decimal> XiWaMaxNumber { get; set; }
    }
}
