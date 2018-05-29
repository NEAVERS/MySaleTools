using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PosvipcardtypesView
    {
        public int CardTypeId { get; set; }
        public string CardTypeName { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public int LimitTotal { get; set; }
        public int IntegralMod { get; set; }
        public string OperateId { get; set; }
        public string DiscountType { get; set; }
        public string PriceTypeId { get; set; }
        public int IsMoney { get; set; }
        public int NeedPass { get; set; }
        public string isStop { get; set; }
        public int type { get; set; }
        public string cBYZD1 { get; set; }
        public string cBYZD2 { get; set; }
        public int iBYZD1 { get; set; }
        public int iBYZD2 { get; set; }
        public int nBYZD1 { get; set; }
        public int nBYZD2 { get; set; }
        public string BranchID { get; set; }
        public int IsAllowAdd { get; set; }
    }
}
