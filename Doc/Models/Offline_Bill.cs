using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Offline_Bill
    {
        public System.Guid OFF_ID { get; set; }
        public decimal BillNumberId { get; set; }
        public string Comment { get; set; }
        public string AtypeId { get; set; }
        public string PtypeId { get; set; }
        public string BtypeId { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> ReachQty { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> SalePrice { get; set; }
        public Nullable<decimal> TaxPrice { get; set; }
        public Nullable<decimal> TaxTotal { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<decimal> totalinmoney { get; set; }
        public Nullable<decimal> discount { get; set; }
        public Nullable<decimal> DiscountPrice { get; set; }
        public Nullable<decimal> costprice { get; set; }
        public string JobNumber { get; set; }
        public Nullable<int> GoodsNo { get; set; }
        public string inorout { get; set; }
        public Nullable<System.DateTime> OutFactoryDate { get; set; }
        public bool Checked { get; set; }
        public Nullable<int> ID { get; set; }
        public Nullable<int> TeamNo { get; set; }
        public Nullable<int> TeamNO1 { get; set; }
        public Nullable<decimal> OrderID { get; set; }
        public int TASKID { get; set; }
        public Nullable<int> OFFLINE_ID { get; set; }
        public int IsUnit2 { get; set; }
    }
}
