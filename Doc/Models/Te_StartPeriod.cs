using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Te_StartPeriod
    {
        public int Id { get; set; }
        public string STypeId { get; set; }
        public Nullable<int> SFYear { get; set; }
        public Nullable<int> SFPeriod { get; set; }
        public Nullable<int> IsConnect { get; set; }
        public Nullable<int> CFYear { get; set; }
        public Nullable<int> CFPeriod { get; set; }
        public Nullable<int> IsUse { get; set; }
    }
}
