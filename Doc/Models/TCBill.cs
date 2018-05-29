using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TCBill
    {
        public decimal BillnumberID { get; set; }
        public string PtypeID { get; set; }
        public string EtypeID { get; set; }
        public string SubName { get; set; }
        public string Sub { get; set; }
        public int Row { get; set; }
        public int ConstFlag { get; set; }
    }
}
