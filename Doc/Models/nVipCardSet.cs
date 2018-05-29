using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class nVipCardSet
    {
        public int VipCardTypeID { get; set; }
        public string TypeName { get; set; }
        public string DiscountType { get; set; }
        public string ifJF { get; set; }
        public string deleted { get; set; }
        public string Comment { get; set; }
        public Nullable<int> VipCardnum { get; set; }
        public Nullable<int> ValidDate { get; set; }
        public Nullable<int> ValidType { get; set; }
        public Nullable<decimal> CardTypeDiscount { get; set; }
        public Nullable<int> jfgz { get; set; }
        public Nullable<decimal> GiveCent { get; set; }
        public Nullable<int> TypeLevel { get; set; }
        public Nullable<decimal> StandardCent { get; set; }
        public Nullable<decimal> DeductCent { get; set; }
        public string IfBirthDay { get; set; }
        public string BirthDayMultiple { get; set; }
        public string IfDate { get; set; }
        public string DateMultiple { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public Nullable<int> IfSalesIntegral { get; set; }
    }
}
