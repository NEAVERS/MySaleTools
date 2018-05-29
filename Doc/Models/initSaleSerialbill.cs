using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class initSaleSerialbill
    {
        public decimal ID { get; set; }
        public Nullable<int> BillNumerID { get; set; }
        public string Serial { get; set; }
        public string KtypeID { get; set; }
        public string PtypeID { get; set; }
        public string BTypeID1 { get; set; }
        public string BtypeID2 { get; set; }
        public Nullable<System.DateTime> InKtypeTime { get; set; }
        public Nullable<System.DateTime> OutKTypeTime { get; set; }
        public Nullable<int> State { get; set; }
    }
}
