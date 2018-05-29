using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PosAssistTypeView
    {
        public int typeid { get; set; }
        public string typename { get; set; }
        public int typeorder { get; set; }
        public int choose { get; set; }
        public string comment { get; set; }
    }
}
