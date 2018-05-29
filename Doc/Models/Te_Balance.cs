using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Te_Balance
    {
        public int Id { get; set; }
        public Nullable<int> AccountId { get; set; }
        public Nullable<int> BUId { get; set; }
        public string ATypeId { get; set; }
        public string STypeId { get; set; }
        public Nullable<decimal> InitBalance { get; set; }
        public Nullable<decimal> InitBalanceFor { get; set; }
        public Nullable<decimal> InitYearBalance { get; set; }
        public Nullable<decimal> InitYearBalanceFor { get; set; }
        public Nullable<int> Cid { get; set; }
        public Nullable<int> FYear { get; set; }
        public Nullable<int> FPeriod { get; set; }
        public Nullable<decimal> FDebit { get; set; }
        public Nullable<decimal> FDebitFor { get; set; }
        public Nullable<decimal> FCredit { get; set; }
        public Nullable<decimal> FCreditFor { get; set; }
        public Nullable<decimal> FEndBalance { get; set; }
        public Nullable<decimal> FEndBalanceFor { get; set; }
        public Nullable<decimal> FYtdDebit { get; set; }
        public Nullable<decimal> FYtdDebitFor { get; set; }
        public Nullable<decimal> FYtdCredit { get; set; }
        public Nullable<decimal> FYtdCreditFor { get; set; }
    }
}
