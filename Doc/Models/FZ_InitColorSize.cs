using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class FZ_InitColorSize
    {
        public string PtypeID { get; set; }
        public string KtypeID { get; set; }
        public int ColorID { get; set; }
        public int SizeID { get; set; }
        public Nullable<decimal> Qty { get; set; }
    }
}
