using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Area
    {
        public int typeid { get; set; }
        public string usercode { get; set; }
        public string Fullname { get; set; }
        public string Comment { get; set; }
        public bool deleted { get; set; }
    }
}
