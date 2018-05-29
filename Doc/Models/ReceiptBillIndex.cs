using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ReceiptBillIndex
    {
        public decimal BillNumberID { get; set; }
        public System.DateTime BillDate { get; set; }
        public string BillCode { get; set; }
        public decimal BillType { get; set; }
        public string FaPiaoType { get; set; }
        public string FaPiaoCode { get; set; }
        public string Comment { get; set; }
        public string Explain { get; set; }
        public string BTypeID { get; set; }
        public string ETypeID { get; set; }
        public string DTypeID { get; set; }
        public string checke { get; set; }
        public string Assessor { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public Nullable<decimal> TotalQty { get; set; }
        public Nullable<decimal> TotalMoney { get; set; }
        public Nullable<decimal> TaxTotalMoney { get; set; }
        public string Stypeid { get; set; }
        public Nullable<decimal> OtherTotal { get; set; }
        public Nullable<int> ifYearBill { get; set; }
        public Nullable<bool> IsIni { get; set; }
        public Nullable<int> CID { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<decimal> NTotalMoney { get; set; }
        public Nullable<decimal> NTaxTotalMoney { get; set; }
        public string DealBTypeID { get; set; }
        public Nullable<byte> TaskType { get; set; }
        public Nullable<int> AlertDay { get; set; }
        public int RedWord { get; set; }
        public string ifcheck { get; set; }
        public int IfStopMoney { get; set; }
        public Nullable<decimal> CompleteTotal { get; set; }
        public Nullable<decimal> NCompleteTotal { get; set; }
        public bool Draft { get; set; }
        public string JSState { get; set; }
        public string JSStyle { get; set; }
        public string Poster { get; set; }
        public Nullable<System.DateTime> LastUpdateTime { get; set; }
        public Nullable<System.DateTime> checkTime { get; set; }
        public Nullable<System.DateTime> Posttime { get; set; }
        public string UpdateE { get; set; }
        public string IfAudit { get; set; }
        public string ATypeID1 { get; set; }
        public string ATypeID2 { get; set; }
        public Nullable<short> Period { get; set; }
        public string RedReason { get; set; }
        public Nullable<int> ATID { get; set; }
        public string Reconciliation { get; set; }
        public Nullable<int> TeamNo { get; set; }
        public string TallyId { get; set; }
        public Nullable<decimal> ChargeOffTotal { get; set; }
        public Nullable<decimal> NChargeOffTotal { get; set; }
    }
}
