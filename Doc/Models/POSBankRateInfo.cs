using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class POSBankRateInfo
    {
        public int rateid { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public string bankitemid { get; set; }
        public string payitemid { get; set; }
        public Nullable<decimal> payrate { get; set; }
        public Nullable<decimal> limittotal { get; set; }
        public int retaildefault { get; set; }
        public bool ratestate { get; set; }
        public string comment { get; set; }
    }
}
