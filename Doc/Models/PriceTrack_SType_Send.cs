using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PriceTrack_SType_Send
    {
        public string BTypeID { get; set; }
        public int BTypeFlag { get; set; }
        public string PTypeID { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountRate { get; set; }
        public decimal DiscountPrice { get; set; }
        public int UID { get; set; }
        public int CID { get; set; }
        public decimal Tax { get; set; }
        public decimal TaxPrice { get; set; }
        public System.DateTime TrackTime { get; set; }
    }
}
