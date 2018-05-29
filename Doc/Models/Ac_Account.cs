using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_Account
    {
        public string StypeId { get; set; }
        public string TypeId { get; set; }
        public string ParId { get; set; }
        public int Leveal { get; set; }
        public int SonNum { get; set; }
        public int SonCount { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public Nullable<int> Fdc { get; set; }
        public Nullable<int> IsCash { get; set; }
        public Nullable<int> IsBank { get; set; }
        public Nullable<int> IsDiary { get; set; }
        public Nullable<int> IsPreGather { get; set; }
        public Nullable<int> IsPrePay { get; set; }
        public Nullable<int> IsGather { get; set; }
        public Nullable<int> IsPay { get; set; }
        public Nullable<int> IsVip { get; set; }
        public string Comment { get; set; }
        public string PyCode { get; set; }
        public string ETypeId { get; set; }
        public System.DateTime CreateDateTime { get; set; }
        public string MainItems { get; set; }
        public string AdditionItems { get; set; }
        public Nullable<int> ExchId { get; set; }
        public Nullable<int> FAcctint { get; set; }
        public Nullable<int> FAcnt { get; set; }
        public string AscIds { get; set; }
        public Nullable<int> FAdjustRate { get; set; }
        public Nullable<int> FContact { get; set; }
        public Nullable<int> FInterest { get; set; }
        public Nullable<decimal> FintRate { get; set; }
        public int FLeveal { get; set; }
        public int Deleted { get; set; }
        public int XiWaMaxNumber { get; set; }
        public int IsOther { get; set; }
        public Nullable<int> Cid { get; set; }
        public Nullable<int> IsDist { get; set; }
        public long KeyId { get; set; }
        public string Group { get; set; }
        public Nullable<int> CheckType { get; set; }
    }
}
