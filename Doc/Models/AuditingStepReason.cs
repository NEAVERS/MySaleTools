using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AuditingStepReason
    {
        public int AuditingID { get; set; }
        public int AuditingStep { get; set; }
        public string AuditingReason { get; set; }
        public string OutKty { get; set; }
        public int Id { get; set; }
    }
}
