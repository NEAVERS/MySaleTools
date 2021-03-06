using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_Balance_Assist_CheckItems_Detail
    {
        public string STypeId { get; set; }
        public string ATypeId { get; set; }
        public Nullable<int> Cid { get; set; }
        public Nullable<int> Ascids { get; set; }
        public string FieldValue { get; set; }
        public Nullable<decimal> FDebit { get; set; }
        public Nullable<decimal> FDebitFor { get; set; }
        public Nullable<decimal> FCredit { get; set; }
        public Nullable<decimal> FCreditFor { get; set; }
        public Nullable<decimal> IniTotal { get; set; }
        public Nullable<decimal> IniTotalFor { get; set; }
        public Nullable<decimal> FEndBalance { get; set; }
        public Nullable<decimal> FEndBalanceFor { get; set; }
        public string FYear { get; set; }
        public Nullable<int> FPeriod { get; set; }
    }
}
