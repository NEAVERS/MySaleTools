using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CustomReference
    {
        public long id { get; set; }
        public long itemsId { get; set; }
        public Nullable<long> selfDataId { get; set; }
        public int childCount { get; set; }
    }
}
