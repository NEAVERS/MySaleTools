using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class IntercourseSetting
    {
        public int ID { get; set; }
        public string BtypeId { get; set; }
        public string StypeId { get; set; }
        public Nullable<int> LimitDay { get; set; }
    }
}
