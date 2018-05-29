using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class LocalDetail
    {
        public decimal ID { get; set; }
        public decimal BillNumberID { get; set; }
        public decimal BillType { get; set; }
        public string PTypeID { get; set; }
        public string LTypeID { get; set; }
        public string LTypeID2 { get; set; }
        public Nullable<decimal> QTY { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<int> TeamNo { get; set; }
        public Nullable<int> TeamNo1 { get; set; }
        public Nullable<int> IsUnit2 { get; set; }
        public string Serial { get; set; }
        public string Comment { get; set; }
    }
}
