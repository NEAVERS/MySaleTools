using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Qp_SuccorBill
    {
        public decimal BillNumberId { get; set; }
        public string LinkPerson { get; set; }
        public string LinkTel { get; set; }
        public string ServiceCardNo { get; set; }
        public string SuccorAddr { get; set; }
        public Nullable<int> SuccorId { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> ReachDate { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
    }
}
