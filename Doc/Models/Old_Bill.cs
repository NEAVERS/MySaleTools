using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Old_Bill
    {
        public decimal BillNumberId { get; set; }
        public Nullable<int> BillType { get; set; }
        public Nullable<int> ID { get; set; }
        public string PTypeID { get; set; }
        public string KTypeID { get; set; }
        public string STypeID { get; set; }
        public Nullable<System.DateTime> PostTime { get; set; }
        public Nullable<System.DateTime> BillDate { get; set; }
    }
}
