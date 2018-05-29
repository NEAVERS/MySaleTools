using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ini_GOODSSTOCKS_QTY
    {
        public int ID { get; set; }
        public string PTypeID { get; set; }
        public string KTypeID { get; set; }
        public Nullable<int> CargoID { get; set; }
        public Nullable<int> ItemID { get; set; }
        public Nullable<bool> Iscombined { get; set; }
        public string GoodsNumber { get; set; }
        public string ProduceDate { get; set; }
        public string ValidDate { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> NQty { get; set; }
        public Nullable<decimal> GoodsCostPrice { get; set; }
    }
}
