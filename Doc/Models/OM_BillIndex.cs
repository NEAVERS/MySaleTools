using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OM_BillIndex
    {
        public int BillNumberID { get; set; }
        public Nullable<System.DateTime> BillDate { get; set; }
        public Nullable<int> State { get; set; }
        public string CancelReason { get; set; }
        public string BillCode { get; set; }
        public Nullable<int> BillType { get; set; }
        public string BtypeID { get; set; }
        public int LoginUser_ID { get; set; }
        public Nullable<decimal> TotalReturnQty { get; set; }
        public Nullable<System.DateTime> CompeledDate { get; set; }
    }
}
