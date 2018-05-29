using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class FixedAssetsIndex
    {
        public Nullable<System.DateTime> createdate { get; set; }
        public string billcode { get; set; }
        public decimal BillNumberID { get; set; }
        public string stypeid { get; set; }
        public string dtypeId { get; set; }
        public string etypeId { get; set; }
        public Nullable<int> state { get; set; }
        public string memo { get; set; }
        public string comment { get; set; }
    }
}
