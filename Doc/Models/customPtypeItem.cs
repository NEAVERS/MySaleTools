using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class customPtypeItem
    {
        public long id { get; set; }
        public string usercode { get; set; }
        public string fullname { get; set; }
        public string referenceIdList { get; set; }
        public Nullable<int> isUse { get; set; }
    }
}
