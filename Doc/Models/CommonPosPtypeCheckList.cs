using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CommonPosPtypeCheckList
    {
        public int CheckCode { get; set; }
        public int CheckList { get; set; }
        public string PtypeID { get; set; }
        public Nullable<int> ColorID { get; set; }
        public Nullable<int> SizeID { get; set; }
        public decimal Qty { get; set; }
        public int IsUpSend { get; set; }
        public int UpLoadPosVchCode { get; set; }
        public string UniqueID { get; set; }
    }
}
