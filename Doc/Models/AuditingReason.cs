using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AuditingReason
    {
        public int AuditingID { get; set; }
        public int ReasonNo { get; set; }
        public string ReasonValue { get; set; }
        public Nullable<int> AuditingStep { get; set; }
        public int Id { get; set; }
    }
}
