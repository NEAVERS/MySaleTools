using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class GoodsLocal
    {
        public string PTypeID { get; set; }
        public string LTypeID { get; set; }
        public string JobNumber { get; set; }
        public Nullable<System.DateTime> OutFactoryDate { get; set; }
        public Nullable<decimal> QTY { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<int> GoodsOrder { get; set; }
    }
}
