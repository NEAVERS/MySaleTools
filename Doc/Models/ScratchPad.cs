using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ScratchPad
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public int SP_ID { get; set; }
        public double SP_X { get; set; }
        public double SP_Y { get; set; }
        public double Width { get; set; }
        public double Hight { get; set; }
        public string SP_Text { get; set; }
        public string Style { get; set; }
        public double Opacity { get; set; }
    }
}
