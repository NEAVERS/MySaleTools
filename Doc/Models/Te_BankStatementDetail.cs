using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Te_BankStatementDetail
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> Businessdate { get; set; }
        public string BusinessId { get; set; }
        public string TellerName { get; set; }
        public Nullable<int> FSettleId { get; set; }
        public string FSettleNo { get; set; }
        public string ETypeId { get; set; }
        public string Summary { get; set; }
        public Nullable<decimal> FDebit { get; set; }
        public Nullable<decimal> FCredit { get; set; }
        public Nullable<decimal> FEndBalance { get; set; }
        public Nullable<int> SourceId { get; set; }
        public Nullable<int> AccountId { get; set; }
        public Nullable<int> FDC { get; set; }
        public Nullable<int> Cid { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<int> IsInit { get; set; }
    }
}
