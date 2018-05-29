using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class gp_inoutPtypeSerial
    {
        public string Serial { get; set; }
        public string PtypeID { get; set; }
        public string BillNumberid { get; set; }
        public string InKtypeID { get; set; }
        public string OutKtyeID { get; set; }
        public string IfCheck { get; set; }
        public Nullable<int> BillType { get; set; }
        public string BTypeID1 { get; set; }
        public string BTypeID2 { get; set; }
        public Nullable<System.DateTime> InKtypeTime { get; set; }
        public Nullable<System.DateTime> OutKtypeTime { get; set; }
        public string User { get; set; }
        public Nullable<int> State { get; set; }
        public decimal ID { get; set; }
        public Nullable<decimal> CostPrice { get; set; }
        public Nullable<int> GoodsOrder { get; set; }
        public string GoodsNumber { get; set; }
        public Nullable<System.DateTime> PostTime { get; set; }
        public Nullable<int> ItemID { get; set; }
        public Nullable<bool> IsCombined { get; set; }
        public Nullable<int> CargoID { get; set; }
        public string ProduceDate { get; set; }
        public string ValidDate { get; set; }
    }
}
