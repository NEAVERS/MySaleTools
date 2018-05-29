using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OM_OrderDetails
    {
        public int BillNumberID { get; set; }
        public Nullable<int> Billindex_ID { get; set; }
        public string PtypeID { get; set; }
        public string StypeID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> TaxRate { get; set; }
        public Nullable<decimal> TaxAmount { get; set; }
        public Nullable<decimal> PriceNoTax { get; set; }
        public Nullable<decimal> TotalPriceNoTax { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> DiscountPrice { get; set; }
        public Nullable<decimal> DiscountTotalPrice { get; set; }
        public Nullable<bool> PriceNature { get; set; }
        public Nullable<decimal> SpecalPrice { get; set; }
        public Nullable<decimal> SpecalTotalPrice { get; set; }
        public Nullable<decimal> ShipmentsQty { get; set; }
        public Nullable<decimal> OutQty { get; set; }
    }
}
