using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CostReLog
    {
        public int ID { get; set; }
        public string PTypeID { get; set; }
        public string STypeID { get; set; }
        public Nullable<System.DateTime> PostTime { get; set; }
        public string OperatorID { get; set; }
        public Nullable<System.DateTime> DealTime { get; set; }
        public Nullable<long> BillNumberID { get; set; }
        public Nullable<int> BillType { get; set; }
    }
}
