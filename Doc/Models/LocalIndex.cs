using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class LocalIndex
    {
        public decimal BillNumberID { get; set; }
        public decimal BillType { get; set; }
        public string BillCode { get; set; }
        public System.DateTime BillDate { get; set; }
        public string KTypeID { get; set; }
        public string ETypeID { get; set; }
        public string IfCheck { get; set; }
        public Nullable<decimal> TotalQty { get; set; }
        public Nullable<decimal> BID { get; set; }
        public string BCode { get; set; }
        public Nullable<short> Period { get; set; }
        public string Comment { get; set; }
        public string Explain { get; set; }
        public int RedWord { get; set; }
        public bool Draft { get; set; }
        public string Assessor { get; set; }
        public string ETypeID1 { get; set; }
        public string EtypeID2 { get; set; }
    }
}
