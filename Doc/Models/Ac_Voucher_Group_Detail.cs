using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_Voucher_Group_Detail
    {
        public int VgdId { get; set; }
        public Nullable<int> VgId { get; set; }
        public string ATypeId { get; set; }
        public Nullable<int> IsDebit { get; set; }
        public Nullable<int> IsCredit { get; set; }
        public Nullable<int> IsDebitOrCredit { get; set; }
        public Nullable<int> IsNoDebit { get; set; }
        public Nullable<int> IsNoCredit { get; set; }
        public Nullable<int> IsNoDebitAndCredit { get; set; }
    }
}
