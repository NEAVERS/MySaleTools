using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PosPtypePriceView
    {
        public string PriceTypeId { get; set; }
        public string Ptypeid { get; set; }
        public Nullable<decimal> Price { get; set; }
    }
}
