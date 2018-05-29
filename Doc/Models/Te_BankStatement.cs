using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Te_BankStatement
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> Businessdate { get; set; }
        public Nullable<decimal> YesterdayFBalance { get; set; }
        public Nullable<decimal> FDebitTotal { get; set; }
        public Nullable<decimal> FCreditTotal { get; set; }
        public Nullable<decimal> FBalance { get; set; }
        public Nullable<int> AccountId { get; set; }
        public Nullable<int> Cid { get; set; }
        public Nullable<int> FDC { get; set; }
    }
}
