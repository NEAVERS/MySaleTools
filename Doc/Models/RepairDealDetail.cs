using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RepairDealDetail
    {
        public decimal BillNumberId { get; set; }
        public string InOrOut { get; set; }
        public string PtypeId { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> SalePrice { get; set; }
        public Nullable<decimal> discount { get; set; }
        public Nullable<decimal> DiscountPrice { get; set; }
        public Nullable<decimal> costprice { get; set; }
        public string jobnumber { get; set; }
        public Nullable<decimal> goodsno { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<System.DateTime> OutFactoryDate { get; set; }
        public Nullable<decimal> TaxPrice { get; set; }
        public Nullable<decimal> TaxTotal { get; set; }
        public string comment { get; set; }
        public Nullable<int> OrderID { get; set; }
        public Nullable<int> TeamNo { get; set; }
        public int ID { get; set; }
        public Nullable<int> TeamNO1 { get; set; }
        public int IsUnit2 { get; set; }
        public string Serial { get; set; }
        public Nullable<decimal> InputCostPrice { get; set; }
        public Nullable<int> GoodsOrder { get; set; }
        public string GoodsNumber { get; set; }
        public string ProduceDate { get; set; }
        public string ValidDate { get; set; }
        public string GoodsBTypeID { get; set; }
        public Nullable<decimal> GoodsCostPrice { get; set; }
        public Nullable<decimal> GoodsCostTotal { get; set; }
        public Nullable<int> HandZeroCost { get; set; }
    }
}
