using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Te_AccountInTransit_Detail
    {
        public int Id { get; set; }
        public Nullable<int> IndexId { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string Summary { get; set; }
        public string ETypeId { get; set; }
        public Nullable<int> FSettleId { get; set; }
        public string FSettleNo { get; set; }
        public Nullable<decimal> FDebit { get; set; }
        public Nullable<decimal> FCredit { get; set; }
        public Nullable<decimal> FDebitOri { get; set; }
        public Nullable<decimal> FCreditOri { get; set; }
    }
}
