using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_Assist_CheckItems_BillType
    {
        public int nId { get; set; }
        public int AscIds { get; set; }
        public int BillType { get; set; }
        public string FullName { get; set; }
        public string FieldValue { get; set; }
        public Nullable<int> AuditType { get; set; }
        public Nullable<int> InOutType { get; set; }
    }
}
