using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_Voucher
    {
        public string STypeId { get; set; }
        public Nullable<int> VgId { get; set; }
        public decimal BillNumberId { get; set; }
        public Nullable<System.DateTime> BillDate { get; set; }
        public string BillCode { get; set; }
        public Nullable<decimal> FlowNo { get; set; }
        public Nullable<int> AttachFileCount { get; set; }
        public string TallyId { get; set; }
        public Nullable<int> FChecked { get; set; }
        public string AuditId { get; set; }
        public string ETypeId { get; set; }
        public string FYear { get; set; }
        public Nullable<int> FPeriod { get; set; }
        public string MarkError { get; set; }
        public Nullable<decimal> FCreditTotal { get; set; }
        public Nullable<decimal> FDebitTotal { get; set; }
        public Nullable<int> FEntryCount { get; set; }
        public Nullable<System.DateTime> FModifyTime { get; set; }
        public string FComment { get; set; }
        public string FFootNote { get; set; }
        public Nullable<int> Audited { get; set; }
        public Nullable<int> FSerialNum { get; set; }
        public string Teller { get; set; }
        public Nullable<int> IsSelect { get; set; }
        public string ReCheckId { get; set; }
        public string IfCheck { get; set; }
        public Nullable<System.DateTime> posttime { get; set; }
        public Nullable<int> RedWord { get; set; }
        public Nullable<int> VoucherType { get; set; }
        public Nullable<int> IsCommission { get; set; }
    }
}
