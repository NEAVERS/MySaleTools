using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AuditingRelation
    {
        public int OffSet { get; set; }
        public string KeyName { get; set; }
        public string Relation { get; set; }
        public string UnChecked { get; set; }
        public string Description { get; set; }
        public Nullable<int> TabOrder { get; set; }
        public int Id { get; set; }
    }
}
