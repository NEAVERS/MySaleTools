using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class FZ_InOutColorSize
    {
        public System.DateTime BillDate { get; set; }
        public string BillNumberID { get; set; }
        public decimal BillType { get; set; }
        public string PtypeID { get; set; }
        public string KtypeID { get; set; }
        public int ColorID { get; set; }
        public int SizeID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public int IfCheck { get; set; }
    }
}
