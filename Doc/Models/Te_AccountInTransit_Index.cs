using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Te_AccountInTransit_Index
    {
        public int Id { get; set; }
        public Nullable<int> AccountId { get; set; }
        public Nullable<decimal> FDebitTotal { get; set; }
        public Nullable<decimal> FCreditTotal { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<int> IsInit { get; set; }
        public string ATypeId { get; set; }
        public Nullable<int> Cid { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<decimal> FDebitTotalOri { get; set; }
        public Nullable<decimal> FCreditTotalOri { get; set; }
    }
}
