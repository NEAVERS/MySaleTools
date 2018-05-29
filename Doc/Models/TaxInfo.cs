using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TaxInfo
    {
        public int TaxID { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public Nullable<int> TaxType { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public string Comment { get; set; }
        public string PyCode { get; set; }
    }
}
