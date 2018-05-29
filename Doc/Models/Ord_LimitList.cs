using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ord_LimitList
    {
        public int Id { get; set; }
        public int PlugId { get; set; }
        public string QXName { get; set; }
        public string QXEnum { get; set; }
        public Nullable<int> plugmenuid { get; set; }
        public Nullable<int> limittype { get; set; }
    }
}
