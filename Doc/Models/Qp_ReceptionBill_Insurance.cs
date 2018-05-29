using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Qp_ReceptionBill_Insurance
    {
        public decimal BillNumberId { get; set; }
        public int ID { get; set; }
        public string BTypeID { get; set; }
        public Nullable<System.DateTime> AccidentDate { get; set; }
        public string AccidentAddr { get; set; }
        public string AccidentReason { get; set; }
    }
}
