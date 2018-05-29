using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class StockCheck
    {
        public int StockCheckID { get; set; }
        public string PTypeID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public int Id { get; set; }
        public string GoodsNumber { get; set; }
        public string ProduceDate { get; set; }
        public string ValidDate { get; set; }
        public string GoodsBTypeID { get; set; }
        public Nullable<decimal> GoodsCostPrice { get; set; }
        public Nullable<decimal> GoodsCostTotal { get; set; }
        public Nullable<int> HandZeroCost { get; set; }
        public Nullable<decimal> StockQty { get; set; }
        public string CargoSpace { get; set; }
        public Nullable<int> CargoID { get; set; }
        public Nullable<long> ItemID { get; set; }
        public Nullable<int> IsCombined { get; set; }
        public Nullable<int> ShowOrder { get; set; }
        public Nullable<decimal> nqty { get; set; }
        public Nullable<decimal> stocknqty { get; set; }
    }
}
