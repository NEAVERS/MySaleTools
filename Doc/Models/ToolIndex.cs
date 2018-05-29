using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ToolIndex
    {
        public decimal BillNumberId { get; set; }
        public Nullable<System.DateTime> BillDate { get; set; }
        public string BillCode { get; set; }
        public Nullable<decimal> BillType { get; set; }
        public string ETypeID { get; set; }
        public string STypeID { get; set; }
        public string DTypeID { get; set; }
        public string Checke { get; set; }
        public string Explain { get; set; }
        public string Comment { get; set; }
        public string InOutType { get; set; }
    }
}
