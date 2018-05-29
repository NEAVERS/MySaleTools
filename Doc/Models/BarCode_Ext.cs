using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class BarCode_Ext
    {
        public int BarCodeID { get; set; }
        public int StartNum { get; set; }
        public int EndNum { get; set; }
        public int SourceID { get; set; }
    }
}
