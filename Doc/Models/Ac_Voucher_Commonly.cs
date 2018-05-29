using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_Voucher_Commonly
    {
        public string BillCode { get; set; }
        public string BillName { get; set; }
        public string STypeId { get; set; }
        public Nullable<int> VgId { get; set; }
        public decimal BillNumberId { get; set; }
        public Nullable<int> AttachFileCount { get; set; }
        public string ETypeId { get; set; }
        public string FYear { get; set; }
        public Nullable<int> FPeriod { get; set; }
        public Nullable<decimal> FDebitTotal { get; set; }
        public Nullable<decimal> FCreditTotal { get; set; }
        public Nullable<int> FEntryCount { get; set; }
        public Nullable<System.DateTime> FModifyTime { get; set; }
        public string FComment { get; set; }
    }
}
