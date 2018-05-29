using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Te_InitDataDetail
    {
        public int Id { get; set; }
        public Nullable<int> IndexId { get; set; }
        public string AtypeId { get; set; }
        public Nullable<decimal> FDebit { get; set; }
        public Nullable<decimal> FCredit { get; set; }
        public Nullable<decimal> InitBalance { get; set; }
        public Nullable<int> AccountId { get; set; }
        public Nullable<decimal> FDebitOri { get; set; }
        public Nullable<decimal> FCreditOri { get; set; }
        public Nullable<decimal> InitBalanceOri { get; set; }
    }
}
