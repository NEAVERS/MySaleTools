using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OM_Shipments
    {
        public decimal ID { get; set; }
        public Nullable<int> OMBillID { get; set; }
        public Nullable<int> GoodsBillID { get; set; }
        public Nullable<decimal> ReachQty { get; set; }
        public Nullable<decimal> ConfirmQty { get; set; }
        public Nullable<bool> STATUS { get; set; }
        public string comment { get; set; }
    }
}
