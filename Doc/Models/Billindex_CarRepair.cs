using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Billindex_CarRepair
    {
        public decimal BillNumberId { get; set; }
        public System.DateTime BillDate { get; set; }
        public decimal BillType { get; set; }
        public string RATypeID { get; set; }
        public string OperationSort { get; set; }
        public string RepairMode { get; set; }
        public string Oil { get; set; }
        public string Mileage { get; set; }
        public string EpibolyItem { get; set; }
        public string OtherItem { get; set; }
        public int Status { get; set; }
        public Nullable<decimal> ManHourTotal { get; set; }
        public Nullable<decimal> ManHourTax { get; set; }
        public Nullable<decimal> ManHourTaxTotal { get; set; }
        public Nullable<decimal> PTypeTotal { get; set; }
        public Nullable<decimal> PTypeTax { get; set; }
        public Nullable<decimal> PTypeTaxTotal { get; set; }
        public Nullable<decimal> EpibolyTotal { get; set; }
        public Nullable<decimal> OtherTotal { get; set; }
        public string InPriceType { get; set; }
        public string BTypeID1 { get; set; }
        public Nullable<decimal> QuickRepairBillID { get; set; }
        public Nullable<decimal> ManHourInsuranceTotal { get; set; }
        public Nullable<decimal> PTypeInsuranceTotal { get; set; }
        public Nullable<int> InvoiceMode { get; set; }
        public string InvoiceCode { get; set; }
        public int InsuranceStatus { get; set; }
        public Nullable<int> RepairType { get; set; }
        public Nullable<System.DateTime> BespokeDate { get; set; }
        public Nullable<System.DateTime> ReceptionDate { get; set; }
        public Nullable<System.DateTime> CompleteDate { get; set; }
        public Nullable<System.DateTime> InFactoryDate { get; set; }
        public Nullable<System.DateTime> FactCompleteDate { get; set; }
        public string ReceptionId { get; set; }
        public string UnitSatrap { get; set; }
        public string SendPerson { get; set; }
        public string ErrDescription { get; set; }
        public Nullable<decimal> EpibolyCostTotal { get; set; }
        public string PreferenceReason { get; set; }
        public Nullable<System.DateTime> BalanceDate { get; set; }
        public string ItemPrincipal { get; set; }
        public string MonitorPrincipal { get; set; }
        public Nullable<int> BillState { get; set; }
        public Nullable<decimal> IntendingKickback { get; set; }
        public Nullable<decimal> SettlementKickback { get; set; }
        public Nullable<int> BackTypeId { get; set; }
        public Nullable<System.DateTime> IntendingTalkBackDate { get; set; }
        public Nullable<int> IsTalkBackOver { get; set; }
        public Nullable<int> CounterClaimStatus { get; set; }
        public Nullable<int> CzBeforeTimes { get; set; }
        public string RepairAutoTypeId { get; set; }
    }
}
