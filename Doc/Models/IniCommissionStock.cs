using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class IniCommissionStock
    {
        public string Ptypeid { get; set; }
        public string Btypeid { get; set; }
        public int Type { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> CostTotal { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public Nullable<decimal> TaxTotal { get; set; }
        public string explain { get; set; }
        public string KtypeId { get; set; }
        public string EtypeId { get; set; }
        public string Stypeid { get; set; }
        public Nullable<byte> DealType { get; set; }
        public Nullable<byte> SerialType { get; set; }
    }
}
