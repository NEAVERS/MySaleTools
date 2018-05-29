using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class VipCardConsume
    {
        public int VipCardConsumeId { get; set; }
        public string VipCardNo { get; set; }
        public Nullable<System.DateTime> PreConsumeDate { get; set; }
        public Nullable<decimal> PreConsumeMoney { get; set; }
        public Nullable<decimal> PreConsumeRate { get; set; }
        public Nullable<decimal> PreConsumeZkMoney { get; set; }
        public Nullable<decimal> SumConsumeMoney { get; set; }
        public Nullable<decimal> NextZkRate { get; set; }
        public Nullable<decimal> SumConsumeZkMoney { get; set; }
        public Nullable<int> BillNumberID { get; set; }
    }
}
