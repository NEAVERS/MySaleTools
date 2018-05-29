using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CX_CombinationBill
    {
        public int BillNumberId { get; set; }
        public int Row { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public string EntryCode { get; set; }
        public Nullable<decimal> SalePrice { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> DiscountPrice { get; set; }
        public Nullable<decimal> MemberPrice { get; set; }
    }
}
