using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PromoRule
    {
        public decimal ID { get; set; }
        public string BillCode { get; set; }
        public string FullName { get; set; }
        public Nullable<int> PromoStylePtype { get; set; }
        public Nullable<int> PromoStyleDiscount { get; set; }
        public Nullable<int> VIPConfig { get; set; }
        public Nullable<int> KConfig { get; set; }
        public Nullable<int> EConfig { get; set; }
        public Nullable<int> PConfig { get; set; }
        public Nullable<int> CalculateStyle { get; set; }
        public Nullable<int> BindType { get; set; }
        public Nullable<int> ReachCondition { get; set; }
        public Nullable<int> AccumulatedProfits { get; set; }
        public Nullable<int> DoubleDiscount { get; set; }
        public Nullable<int> BillState { get; set; }
        public string Checke { get; set; }
        public string Checker { get; set; }
        public Nullable<System.DateTime> VaildDate { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string DeletedR { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string PriceDay { get; set; }
        public string Comment { get; set; }
        public Nullable<int> GiftsType { get; set; }
        public Nullable<decimal> XiWaMaxNumber { get; set; }
        public byte[] PosDataVersion { get; set; }
        public int BtypeConfig { get; set; }
    }
}
