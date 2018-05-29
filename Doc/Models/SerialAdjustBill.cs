using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SerialAdjustBill
    {
        public decimal BillNumberId { get; set; }
        public int ID { get; set; }
        public string Serial { get; set; }
        public string OldSerial { get; set; }
        public string KtypeID { get; set; }
        public string PtypeID { get; set; }
        public string BTypeID1 { get; set; }
        public string BTypeID2 { get; set; }
        public Nullable<System.DateTime> InKtypeTime { get; set; }
        public Nullable<System.DateTime> OutKtypeTime { get; set; }
        public int State { get; set; }
        public string Note { get; set; }
        public Nullable<int> sameSearilID { get; set; }
        public Nullable<int> BillId { get; set; }
        public Nullable<int> ShowOrder { get; set; }
    }
}
