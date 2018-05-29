using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RefIndustry
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
}
