using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OM_ReturnGoods
    {
        public int BillNumberID { get; set; }
        public Nullable<int> BillIndex_ID { get; set; }
        public Nullable<int> OrderDetails_ID { get; set; }
        public Nullable<decimal> ReturnGoodsableQty { get; set; }
        public Nullable<decimal> ReturnGoodsQty { get; set; }
        public string Reason { get; set; }
        public Nullable<decimal> ReturnPrice { get; set; }
        public Nullable<decimal> ReturnTotalPrice { get; set; }
    }
}
