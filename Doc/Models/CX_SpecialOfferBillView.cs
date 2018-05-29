using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CX_SpecialOfferBillView
    {
        public int BillNumberId { get; set; }
        public int Row { get; set; }
        public string PtypeId { get; set; }
        public Nullable<decimal> SalePrice { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> DiscountPrice { get; set; }
        public Nullable<decimal> MemberIntegral { get; set; }
        public Nullable<decimal> MemberPrice { get; set; }
    }
}
