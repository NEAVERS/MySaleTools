using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Advantage_standard
    {
        public string StandardCode { get; set; }
        public string StandardName { get; set; }
        public string Etypeid { get; set; }
        public int Type { get; set; }
        public int Dates { get; set; }
        public Nullable<decimal> LowQty { get; set; }
        public Nullable<decimal> HighQty { get; set; }
        public Nullable<decimal> Advantage_Total { get; set; }
        public string explain { get; set; }
        public string Stypeid { get; set; }
    }
}
