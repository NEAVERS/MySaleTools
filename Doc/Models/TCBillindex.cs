using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TCBillindex
    {
        public decimal BillnumberID { get; set; }
        public System.DateTime BillDate { get; set; }
        public string BillCode { get; set; }
        public string Comment { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string checke { get; set; }
        public string EtypeID { get; set; }
    }
}
