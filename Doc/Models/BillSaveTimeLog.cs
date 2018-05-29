using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class BillSaveTimeLog
    {
        public System.DateTime SaveDate { get; set; }
        public int BillTypeID { get; set; }
        public string BillCode { get; set; }
        public Nullable<int> FunctionOrder { get; set; }
        public string FunctionName { get; set; }
        public int Elapsed { get; set; }
    }
}
