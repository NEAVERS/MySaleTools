using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class BATypeIdPreset
    {
        public int Id { get; set; }
        public string BTypeName { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public Nullable<int> SubId { get; set; }
    }
}
