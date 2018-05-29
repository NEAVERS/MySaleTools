using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Te_Period
    {
        public int Id { get; set; }
        public string STypeId { get; set; }
        public Nullable<int> FYear { get; set; }
        public Nullable<int> FPeriod { get; set; }
    }
}
