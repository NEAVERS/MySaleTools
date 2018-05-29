using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OM_ReplacementGoods
    {
        public int BillNumberId { get; set; }
        public Nullable<int> BillIndex_ID { get; set; }
        public Nullable<int> OrderDetails_ID { get; set; }
        public Nullable<decimal> ReplacementGoodsQty { get; set; }
        public Nullable<decimal> ReplacementGoodsableQty { get; set; }
        public string Reason { get; set; }
    }
}
