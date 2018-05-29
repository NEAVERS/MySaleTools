using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class city
    {
        public int id { get; set; }
        public Nullable<int> areaid { get; set; }
        public string Cname { get; set; }
        public Nullable<int> orderid { get; set; }
    }
}
