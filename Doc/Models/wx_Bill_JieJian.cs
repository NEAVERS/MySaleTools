using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class wx_Bill_JieJian
    {
        public decimal BillNumberId { get; set; }
        public string PTypeID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public int IsUnit2 { get; set; }
        public string Serial { get; set; }
        public string BuyDate { get; set; }
        public string ErrDes { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> AddTotal { get; set; }
        public string ErrDeal { get; set; }
        public Nullable<int> RepairMode { get; set; }
        public string ETypeID { get; set; }
        public int BaoXiu { get; set; }
        public string Comment { get; set; }
        public Nullable<int> State { get; set; }
        public string SendBackPTypeID { get; set; }
        public string SendBackSerial { get; set; }
        public Nullable<System.DateTime> OutFactoryDate { get; set; }
        public Nullable<int> ifYearBillDisplay { get; set; }
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
