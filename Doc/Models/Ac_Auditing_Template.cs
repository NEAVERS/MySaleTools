using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_Auditing_Template
    {
        public int AtId { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public Nullable<int> BillType { get; set; }
        public string ETypeId { get; set; }
        public Nullable<int> IsDefault { get; set; }
        public Nullable<System.DateTime> CreateDateTime { get; set; }
        public string PyCode { get; set; }
        public string Comment { get; set; }
        public Nullable<int> FromAtid { get; set; }
        public Nullable<int> AuditType { get; set; }
        public Nullable<int> ChargeOffType { get; set; }
        public Nullable<int> InOutType { get; set; }
        public int VgId { get; set; }
        public string STypeId { get; set; }
        public Nullable<int> Sysrow { get; set; }
        public string Explaintext { get; set; }
        public string ExplainAuditType { get; set; }
        public Nullable<int> IsCombineRow { get; set; }
    }
}
