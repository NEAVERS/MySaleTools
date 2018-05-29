using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class BillOperateLog
    {
        public int Id { get; set; }
        public Nullable<int> BillnumberID { get; set; }
        public string OperateType { get; set; }
        public string EtypeID { get; set; }
        public Nullable<System.DateTime> OperateTime { get; set; }
        public string IP { get; set; }
        public string BillCode { get; set; }
        public Nullable<System.DateTime> BillDate { get; set; }
        public string ifcheck { get; set; }
        public string btypeid { get; set; }
        public Nullable<decimal> NTotalMoney { get; set; }
        public int billtype { get; set; }
    }
}
