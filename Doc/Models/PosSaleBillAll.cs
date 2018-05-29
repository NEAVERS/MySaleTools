using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PosSaleBillAll
    {
        public Nullable<int> BillnumberID { get; set; }
        public Nullable<int> ID { get; set; }
        public Nullable<int> PID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> BackQty { get; set; }
        public Nullable<decimal> RetailPrice { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public Nullable<decimal> DisCount { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> RetailTotal { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<int> UnitID { get; set; }
        public Nullable<decimal> UnitRate { get; set; }
        public Nullable<long> ItemID { get; set; }
        public Nullable<int> IsCombined { get; set; }
        public string BarCode { get; set; }
        public Nullable<int> IsGift { get; set; }
        public string Comment { get; set; }
        public Nullable<int> BaseUnitID { get; set; }
        public int PromoType { get; set; }
        public int SaleEid { get; set; }
        public string producedate { get; set; }
        public string validdate { get; set; }
        public string goodsnumber { get; set; }
        public string serial { get; set; }
        public Nullable<decimal> goodscostprice { get; set; }
        public Nullable<decimal> paymoney { get; set; }
    }
}
