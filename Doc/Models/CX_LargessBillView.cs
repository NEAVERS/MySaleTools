using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CX_LargessBillView
    {
        public int BillNumberId { get; set; }
        public int Row { get; set; }
        public string PtypeId { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public int LargessRow { get; set; }
        public string LargessPtypeId { get; set; }
        public Nullable<decimal> LargessAddTotal { get; set; }
        public Nullable<decimal> LargessQty { get; set; }
    }
}
