using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PromoRule_Detail_PromotConfig
    {
        public decimal ID { get; set; }
        public decimal PromoRuleID { get; set; }
        public Nullable<int> PromoStylePtype { get; set; }
        public Nullable<int> PromoStyleDiscount { get; set; }
        public Nullable<decimal> BuyTotal { get; set; }
        public Nullable<decimal> BuyQty { get; set; }
        public Nullable<decimal> DisCount { get; set; }
        public string Ptypeid { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> OtherTotal { get; set; }
        public Nullable<int> GiftTypeID { get; set; }
        public Nullable<int> CardTypeID { get; set; }
        public string BindPtypeId { get; set; }
    }
}
