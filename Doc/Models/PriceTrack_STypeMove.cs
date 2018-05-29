using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PriceTrack_STypeMove
    {
        public int ID { get; set; }
        public int CID { get; set; }
        public int UnitID { get; set; }
        public string PTypeID { get; set; }
        public int BillType { get; set; }
        public string InSTypeID { get; set; }
        public string OutStypeID { get; set; }
        public decimal RecMovePrice { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public Nullable<decimal> TaxPrice { get; set; }
        public Nullable<decimal> DiscountRate { get; set; }
        public Nullable<System.DateTime> TrackTime { get; set; }
    }
}
