using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class wx_Bill_Move
    {
        public decimal BillNumberID { get; set; }
        public string PTypeID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public int IsUnit2 { get; set; }
        public string Comment { get; set; }
        public string Serial { get; set; }
        public Nullable<System.DateTime> OutFactoryDate { get; set; }
        public int ID { get; set; }
        public string Stypeid { get; set; }
        public Nullable<long> ItemID { get; set; }
        public Nullable<int> IsCombined { get; set; }
        public string GoodsNumber { get; set; }
        public Nullable<int> CargoID { get; set; }
        public Nullable<decimal> NQty { get; set; }
        public Nullable<decimal> UnitRate { get; set; }
        public Nullable<int> ShowOrder { get; set; }
    }
}
