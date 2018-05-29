using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OM_InvoceBill
    {
        public int BillNumberID { get; set; }
        public Nullable<int> BillIndex_ID { get; set; }
        public Nullable<decimal> InvoceQty { get; set; }
        public Nullable<decimal> InvocePrice { get; set; }
        public Nullable<decimal> InvoceTotalPrice { get; set; }
        public Nullable<decimal> InvocedQty { get; set; }
        public Nullable<decimal> InvocedTotalPrice { get; set; }
        public Nullable<decimal> Qty { get; set; }
    }
}
