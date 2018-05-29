using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class nVipAdjust
    {
        public decimal BillNumberId { get; set; }
        public Nullable<System.DateTime> BillDate { get; set; }
        public string BillCode { get; set; }
        public string ETypeId { get; set; }
        public string Checke { get; set; }
        public string VipNo { get; set; }
        public Nullable<decimal> UpCost { get; set; }
        public Nullable<decimal> DownCost { get; set; }
        public Nullable<decimal> SumCost { get; set; }
        public string Reason { get; set; }
        public Nullable<int> IsSend { get; set; }
        public Nullable<int> nType { get; set; }
    }
}
