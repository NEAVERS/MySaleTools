using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PosIsUpdateData
    {
        public int ID { get; set; }
        public string tbType { get; set; }
        public Nullable<decimal> Tid { get; set; }
        public Nullable<int> ifUpdate { get; set; }
        public string stypeid { get; set; }
    }
}
