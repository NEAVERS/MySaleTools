using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Qp_RepairState
    {
        public int StateId { get; set; }
        public string StateName { get; set; }
        public Nullable<int> IsOperation { get; set; }
    }
}
