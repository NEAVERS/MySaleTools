using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PosBtypeDistributeView
    {
        public int Id { get; set; }
        public string BranchId { get; set; }
        public string BtypeId { get; set; }
        public string PriceTypeid { get; set; }
        public string MarketDiscountId { get; set; }
        public string DiscountTypeId { get; set; }
        public int TaxRate { get; set; }
        public int Flag { get; set; }
    }
}
