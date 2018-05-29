using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AuditingBill
    {
        public decimal BillNumberID { get; set; }
        public int AuditingID { get; set; }
        public string AuditingSteps { get; set; }
        public string IfAudit { get; set; }
        public string ETypeID { get; set; }
        public Nullable<System.DateTime> BillDate { get; set; }
        public string BillCode { get; set; }
        public string BillDetail { get; set; }
        public string BillIndexType { get; set; }
        public string PassSteps { get; set; }
        public string StepReasons { get; set; }
    }
}
