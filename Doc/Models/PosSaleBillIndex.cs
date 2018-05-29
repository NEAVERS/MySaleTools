using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PosSaleBillIndex
    {
        public int BillnumberID { get; set; }
        public Nullable<int> Billtype { get; set; }
        public string billdate { get; set; }
        public string BillCode { get; set; }
        public Nullable<int> SID { get; set; }
        public Nullable<int> BID { get; set; }
        public Nullable<int> KID { get; set; }
        public Nullable<int> PosID { get; set; }
        public Nullable<int> EID { get; set; }
        public Nullable<int> VipCardID { get; set; }
        public Nullable<decimal> TotalQty { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> TotalMoney { get; set; }
        public Nullable<decimal> preferencemoney { get; set; }
        public Nullable<decimal> premoney { get; set; }
        public Nullable<decimal> Totalinmoney { get; set; }
        public Nullable<decimal> CashMoney { get; set; }
        public Nullable<decimal> ChangeMoney { get; set; }
        public Nullable<int> BackBillnumberID { get; set; }
        public Nullable<int> UpLoadBillnumberID { get; set; }
        public Nullable<int> PromoRuleId { get; set; }
        public string PromotionMsg { get; set; }
        public Nullable<int> BuyBackType { get; set; }
        public string billtime { get; set; }
    }
}
