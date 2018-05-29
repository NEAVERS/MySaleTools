using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class BtypePriceInfo
    {
        public int id { get; set; }
        public string stypeid { get; set; }
        public string ptypeid { get; set; }
        public string btypeid { get; set; }
        public string areatypeid { get; set; }
        public string ktypeid { get; set; }
        public Nullable<decimal> SalePrice { get; set; }
        public Nullable<decimal> RetailPrice { get; set; }
        public Nullable<decimal> TopbuyPrice { get; set; }
        public Nullable<decimal> BuyPrice { get; set; }
        public Nullable<decimal> LowSalePrice { get; set; }
    }
}
