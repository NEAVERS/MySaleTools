using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OM_Inventory
    {
        public int Id { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public string Comment { get; set; }
        public Nullable<int> CreatorId { get; set; }
        public string CreatorName { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public Nullable<int> ModifierId { get; set; }
        public string ModifierName { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
    }
}
