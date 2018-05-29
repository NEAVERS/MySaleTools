using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class news_catalog
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> ShowOrder { get; set; }
    }
}
