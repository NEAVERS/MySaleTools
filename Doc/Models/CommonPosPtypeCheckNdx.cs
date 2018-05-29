using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CommonPosPtypeCheckNdx
    {
        public int CheckCode { get; set; }
        public string KtypeID { get; set; }
        public string OperatorID { get; set; }
        public string PDDate { get; set; }
        public string PosID { get; set; }
        public int IsUpSend { get; set; }
        public string PDNumber { get; set; }
        public int PDVchCode { get; set; }
        public int UpLoadPosVchCode { get; set; }
        public string UniqueID { get; set; }
    }
}
