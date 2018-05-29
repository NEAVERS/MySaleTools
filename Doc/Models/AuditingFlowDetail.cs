using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AuditingFlowDetail
    {
        public int AuditingID { get; set; }
        public int BillType { get; set; }
        public string AuditingDescription { get; set; }
        public int AuditingStep { get; set; }
        public string ETypeID { get; set; }
        public string AuditingAlerm { get; set; }
        public string OutKty { get; set; }
        public int Id { get; set; }
    }
}
