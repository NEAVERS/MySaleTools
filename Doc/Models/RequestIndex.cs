using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RequestIndex
    {
        public decimal BillNumberId { get; set; }
        public System.DateTime BillDate { get; set; }
        public string BillCode { get; set; }
        public decimal BillType { get; set; }
        public string Comment { get; set; }
        public string dtypeid { get; set; }
        public string etypeid { get; set; }
        public string checke { get; set; }
        public Nullable<decimal> totalqty { get; set; }
        public Nullable<decimal> totalmoney { get; set; }
        public Nullable<short> period { get; set; }
        public string explain { get; set; }
        public string Stypeid { get; set; }
        public Nullable<decimal> tax { get; set; }
        public Nullable<bool> IsIni { get; set; }
        public Nullable<int> CID { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<decimal> NTotalMoney { get; set; }
        public Nullable<int> ifYearBill { get; set; }
        public string IfAudit { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<System.DateTime> RequestDate { get; set; }
        public Nullable<System.DateTime> checkTime { get; set; }
    }
}
