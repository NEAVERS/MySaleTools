using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Te_Journal_Detail
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> BusinessDate { get; set; }
        public Nullable<int> SourceId { get; set; }
        public Nullable<int> VoucherId { get; set; }
        public Nullable<int> GoodsBillNumberId { get; set; }
        public string ETypeId { get; set; }
        public string Summary { get; set; }
        public Nullable<decimal> FDebit { get; set; }
        public Nullable<decimal> FCredit { get; set; }
        public Nullable<decimal> FEndBalance { get; set; }
        public Nullable<int> AccountId { get; set; }
        public Nullable<int> IsCash { get; set; }
        public Nullable<int> FDC { get; set; }
        public string STypeId { get; set; }
        public string ATypeId { get; set; }
        public Nullable<int> FSettleId { get; set; }
        public string FSettleNo { get; set; }
        public Nullable<int> Cid { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<decimal> FDebitOri { get; set; }
        public Nullable<decimal> FCreditOri { get; set; }
        public Nullable<decimal> FEndBalanceOri { get; set; }
        public Nullable<int> IsInit { get; set; }
    }
}
