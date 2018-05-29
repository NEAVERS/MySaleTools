using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class FaPiaoBillIndex
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
        public Nullable<int> ID { get; set; }
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
    }
}
