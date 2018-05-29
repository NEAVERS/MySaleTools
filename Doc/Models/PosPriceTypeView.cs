using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PosPriceTypeView
    {
        public string BranchId { get; set; }
        public string PriceTypeId { get; set; }
        public string PriceName { get; set; }
        public string DisplayName { get; set; }
        public string Type { get; set; }
        public int SortLevel { get; set; }
        public int IsSystem { get; set; }
    }
}
