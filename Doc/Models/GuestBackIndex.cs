using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class GuestBackIndex
    {
        public decimal BillNumberId { get; set; }
        public System.DateTime BillDate { get; set; }
        public string BillCode { get; set; }
        public decimal BillType { get; set; }
        public string Comment { get; set; }
        public string atypeid { get; set; }
        public string ptypeid { get; set; }
        public string btypeid { get; set; }
        public string etypeid { get; set; }
        public string ktypeid { get; set; }
        public string ktypeid2 { get; set; }
        public string ifcheck { get; set; }
        public string checke { get; set; }
        public Nullable<decimal> totalmoney { get; set; }
        public Nullable<decimal> totalinmoney { get; set; }
        public Nullable<decimal> totalqty { get; set; }
        public Nullable<decimal> tax { get; set; }
        public Nullable<short> period { get; set; }
        public string explain { get; set; }
        public bool RedWord { get; set; }
        public bool draft { get; set; }
        public Nullable<decimal> OrderId { get; set; }
        public string WayBillCode { get; set; }
        public Nullable<decimal> GoodsNumber { get; set; }
        public string PackWay { get; set; }
        public string TEL { get; set; }
    }
}
