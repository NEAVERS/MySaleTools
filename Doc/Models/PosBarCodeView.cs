using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PosBarCodeView
    {
        public string ptypeid { get; set; }
        public int colorid { get; set; }
        public int sizeid { get; set; }
        public int BarTypeid { get; set; }
        public string FullBarCode { get; set; }
        public int PRI { get; set; }
    }
}
