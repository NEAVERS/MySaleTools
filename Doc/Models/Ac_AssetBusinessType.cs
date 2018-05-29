using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_AssetBusinessType
    {
        public int Id { get; set; }
        public Nullable<int> BusinessType { get; set; }
        public string FullName { get; set; }
        public Nullable<int> Atid { get; set; }
        public Nullable<int> AuditType { get; set; }
        public string STypeId { get; set; }
        public bool Deleted { get; set; }
    }
}
