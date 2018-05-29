using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_FixedAssets
    {
        public int nId { get; set; }
        public string STypeId { get; set; }
        public string TypeId { get; set; }
        public string ParId { get; set; }
        public int Leveal { get; set; }
        public int SonNum { get; set; }
        public int SonCount { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public string PyCode { get; set; }
        public int Deleted { get; set; }
        public string ATypeId { get; set; }
        public string DepATypeId { get; set; }
        public string DisATypeId { get; set; }
        public Nullable<int> XiWaMaxNumber { get; set; }
    }
}
