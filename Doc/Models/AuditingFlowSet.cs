using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AuditingFlowSet
    {
        public int AuditingID { get; set; }
        public int BillType { get; set; }
        public int AuditingType { get; set; }
        public int AuditingLevel { get; set; }
        public string IfUse { get; set; }
        public string ETypeID { get; set; }
        public string AuditingReason { get; set; }
        public System.DateTime AuditingDate { get; set; }
        public int AuditingLevel1 { get; set; }
        public string Stypeid { get; set; }
        public string LastStopETypeID { get; set; }
        public string LastStartETypeID { get; set; }
        public Nullable<System.DateTime> LastStopTime { get; set; }
        public Nullable<System.DateTime> LastStartTime { get; set; }
        public Nullable<bool> Stoped { get; set; }
    }
}
