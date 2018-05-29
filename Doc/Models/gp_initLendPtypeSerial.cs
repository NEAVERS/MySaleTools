using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class gp_initLendPtypeSerial
    {
        public string Serial { get; set; }
        public string KtypeID { get; set; }
        public string PtypeID { get; set; }
        public string BTypeID1 { get; set; }
        public string BtypeID2 { get; set; }
        public Nullable<System.DateTime> InKtypeTime { get; set; }
        public Nullable<System.DateTime> OutKTypeTime { get; set; }
        public string User { get; set; }
        public Nullable<int> State { get; set; }
        public string Note { get; set; }
        public Nullable<bool> Flag { get; set; }
        public string CommissionState { get; set; }
        public string ETypeID { get; set; }
        public string LTypeID { get; set; }
        public Nullable<bool> BFlag { get; set; }
        public Nullable<int> ItemID { get; set; }
        public Nullable<bool> IsCombined { get; set; }
        public Nullable<int> CargoID { get; set; }
        public string ProduceDate { get; set; }
        public string ValidDate { get; set; }
        public string GoodsNumber { get; set; }
    }
}
