using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AuditingBillDetail
    {
        public decimal BillNumberID { get; set; }
        public string ETypeID { get; set; }
        public string AuditingExplain { get; set; }
        public System.DateTime AuditingDate { get; set; }
        public string AuditingFlag { get; set; }
        public int AuditingStep { get; set; }
        public string BillIndexType { get; set; }
    }
}
