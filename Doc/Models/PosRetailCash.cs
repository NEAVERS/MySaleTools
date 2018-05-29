using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PosRetailCash
    {
        public string Stypeid { get; set; }
        public string CashAtypeid { get; set; }
        public string BankAtypeid { get; set; }
        public string YSAtypeid { get; set; }
        public string StoreCardAtypeid { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public string Comment { get; set; }
    }
}
