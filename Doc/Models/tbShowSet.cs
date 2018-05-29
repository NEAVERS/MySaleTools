using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class tbShowSet
    {
        public int No { get; set; }
        public string FullName { get; set; }
        public string UserCode { get; set; }
        public string TypeId { get; set; }
        public Nullable<bool> IfShow { get; set; }
    }
}
