using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PriceTrack
    {
        public string BtypeID { get; set; }
        public string PtypeID { get; set; }
        public Nullable<decimal> SalePrice { get; set; }
        public Nullable<decimal> CostPrice { get; set; }
        public Nullable<decimal> SaleOrderPrice { get; set; }
        public Nullable<decimal> BuyOrderPrice { get; set; }
        public string Stypeid { get; set; }
        public int BTypeFlag { get; set; }
        public Nullable<decimal> BuyOrBackOriginalPrice { get; set; }
        public Nullable<decimal> BuyOrBackDiscountRate { get; set; }
        public Nullable<decimal> SaleOrBackOriginalPrice { get; set; }
        public Nullable<decimal> SaleOrBackDiscountRate { get; set; }
        public Nullable<decimal> QueryPrice { get; set; }
        public Nullable<decimal> ResponsePrice { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<int> UID { get; set; }
        public Nullable<int> CID { get; set; }
    }
}
