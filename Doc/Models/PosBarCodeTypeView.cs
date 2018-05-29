using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PosBarCodeTypeView
    {
        public int bartypeid { get; set; }
        public string BarName { get; set; }
        public string DisplayBarName { get; set; }
        public int BarCheckDigit { get; set; }
        public int IsStoped { get; set; }
        public int IsDeleted { get; set; }
        public string cBYZD { get; set; }
        public int iBYZD { get; set; }
    }
}
