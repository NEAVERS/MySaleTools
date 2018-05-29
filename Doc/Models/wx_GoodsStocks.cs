using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class wx_GoodsStocks
    {
        public string PTypeId { get; set; }
        public string KTypeId { get; set; }
        public string JobNumber { get; set; }
        public Nullable<System.DateTime> OutFactoryDate { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<int> GoodsOrder { get; set; }
        public string GoodsNumber { get; set; }
        public string ProduceDate { get; set; }
        public string ValidDate { get; set; }
        public string GoodsBTypeID { get; set; }
        public Nullable<int> ItemID { get; set; }
        public Nullable<bool> Iscombined { get; set; }
        public Nullable<decimal> Nqty { get; set; }
        public Nullable<int> CargoID { get; set; }
    }
}
