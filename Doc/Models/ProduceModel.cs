using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ProduceModel
    {
        public Nullable<int> ProduceModelID { get; set; }
        public string PtypeID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public int ID { get; set; }
        public Nullable<int> ShowOrder { get; set; }
    }
}
