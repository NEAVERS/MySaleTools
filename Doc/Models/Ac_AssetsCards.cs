using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_AssetsCards
    {
        public int Id { get; set; }
        public string TypeId { get; set; }
        public string Parid { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public string STypeId { get; set; }
        public string AssertATypeId { get; set; }
        public string DepATypeId { get; set; }
        public string DisATypeId { get; set; }
        public string DevalueATypeId { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> ConditionId { get; set; }
        public string Size { get; set; }
        public string DTypeid { get; set; }
        public Nullable<System.DateTime> InAccountDate { get; set; }
        public Nullable<int> BusinessTypeId { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<int> Cid { get; set; }
        public Nullable<decimal> F_Total { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<decimal> DepTotal { get; set; }
        public Nullable<decimal> DevalueReady { get; set; }
        public Nullable<decimal> NetValue { get; set; }
        public Nullable<decimal> NetSalvage { get; set; }
        public Nullable<decimal> NetSalvageRate { get; set; }
        public Nullable<int> DepreciationMean { get; set; }
        public Nullable<int> DurYear { get; set; }
        public Nullable<int> DepreciationMonth { get; set; }
        public string Units { get; set; }
        public string Comment { get; set; }
        public Nullable<int> AssetsState { get; set; }
        public Nullable<System.DateTime> OperationDate { get; set; }
        public string ETypeId { get; set; }
        public string BarCode { get; set; }
        public Nullable<decimal> ExpectWork { get; set; }
        public Nullable<decimal> FinishWork { get; set; }
        public string WorkUnit { get; set; }
        public Nullable<decimal> XiWaMaxNumber { get; set; }
        public int durmonth { get; set; }
    }
}
