using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class WeighBeamConfig
    {
        public int RecogniseAmount { get; set; }
        public string RecogniseCode { get; set; }
        public int CodingAmount { get; set; }
        public int PriceAmount { get; set; }
        public int WeightAmount { get; set; }
        public Nullable<int> XiaoYanAmount { get; set; }
    }
}
