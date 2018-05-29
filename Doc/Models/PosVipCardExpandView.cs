using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PosVipCardExpandView
    {
        public int CardTypeid { get; set; }
        public int oneconsume { get; set; }
        public int allconsume { get; set; }
        public int Integral1 { get; set; }
        public int Integral2 { get; set; }
        public int ExpandType { get; set; }
        public int Base { get; set; }
        public int Percent { get; set; }
        public int isshop { get; set; }
        public string atypeid { get; set; }
        public int batchno { get; set; }
    }
}
