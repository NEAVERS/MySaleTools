using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class LendBill
    {
        public decimal BillNumberId { get; set; }
        public string PtypeId { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public string JobNumber { get; set; }
        public Nullable<int> GoodsNo { get; set; }
        public Nullable<System.DateTime> OutFactoryDate { get; set; }
        public string comment { get; set; }
        public string Serial { get; set; }
        public Nullable<decimal> BackQty { get; set; }
        public int Id { get; set; }
        public string Stypeid { get; set; }
        public Nullable<int> CargoID { get; set; }
        public int BackItemId { get; set; }
        public Nullable<long> ItemID { get; set; }
        public Nullable<int> IsCombined { get; set; }
        public Nullable<decimal> NQty { get; set; }
        public string GoodsNumber { get; set; }
        public string ProduceDate { get; set; }
        public string ValidDate { get; set; }
        public Nullable<decimal> UnitRate { get; set; }
        public Nullable<int> ShowOrder { get; set; }
        public Nullable<decimal> BuyQty { get; set; }
        public Nullable<decimal> SaleQty { get; set; }
    }
}
