using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class InvoiceBill
    {
        public decimal BillNumberID { get; set; }
        public string IfInVoice { get; set; }
        public string ETypeID { get; set; }
        public string InvoiceStyle { get; set; }
        public Nullable<decimal> InvoiceTotal { get; set; }
        public string Explain { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public string InvoiceNo { get; set; }
        public bool isDraft { get; set; }
        public int InvoiceID { get; set; }
    }
}
