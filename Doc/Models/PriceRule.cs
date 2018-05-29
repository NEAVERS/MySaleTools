using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PriceRule
    {
        public decimal ID { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public decimal PriceBillIndexID { get; set; }
        public Nullable<int> VipConfig { get; set; }
        public Nullable<int> StoresConfig { get; set; }
        public Nullable<int> KConfig { get; set; }
        public Nullable<int> DConfig { get; set; }
        public Nullable<int> EConfig { get; set; }
        public Nullable<int> BConfig { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string PriceDay { get; set; }
        public string Comment { get; set; }
        public Nullable<int> State { get; set; }
        public string Checke { get; set; }
        public string Checker { get; set; }
        public Nullable<System.DateTime> VaildDate { get; set; }
        public string DeletedR { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<decimal> XiWaMaxNumber { get; set; }
        public byte[] PosDataVersion { get; set; }
        public Nullable<int> VipEnable { get; set; }
        public Nullable<int> BtypeEnable { get; set; }
        public Nullable<int> VBEnable { get; set; }
    }
}
