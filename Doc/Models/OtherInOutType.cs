using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OtherInOutType
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string ATypeID { get; set; }
        public Nullable<int> BillType { get; set; }
        public string ATypeID1 { get; set; }
        public Nullable<int> InOutType { get; set; }
    }
}
