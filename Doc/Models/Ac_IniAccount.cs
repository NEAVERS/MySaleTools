using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_IniAccount
    {
        public string STypeId { get; set; }
        public string ATypeId { get; set; }
        public Nullable<decimal> iniYTotal { get; set; }
        public Nullable<decimal> iniYTotalFor { get; set; }
        public Nullable<decimal> FDebit { get; set; }
        public Nullable<decimal> FDebitFor { get; set; }
        public Nullable<decimal> FCredit { get; set; }
        public Nullable<decimal> FCreditFor { get; set; }
        public Nullable<decimal> iniTotal { get; set; }
        public Nullable<decimal> iniTotalFor { get; set; }
        public Nullable<int> Cid { get; set; }
        public string FYear { get; set; }
        public Nullable<int> FPeriod { get; set; }
        public Nullable<decimal> FYTotal { get; set; }
        public Nullable<decimal> FYTotalFor { get; set; }
        public Nullable<decimal> FYTotalDebit { get; set; }
        public Nullable<decimal> FYTotalDebitFor { get; set; }
        public Nullable<decimal> FYTotalCredit { get; set; }
        public Nullable<decimal> FYTotalCreditFor { get; set; }
    }
}
