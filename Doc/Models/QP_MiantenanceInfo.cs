using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class QP_MiantenanceInfo
    {
        public int ID { get; set; }
        public string RepairAutoTypeID { get; set; }
        public Nullable<decimal> hightMileage { get; set; }
        public Nullable<decimal> lowMileage { get; set; }
        public string Suggestion { get; set; }
    }
}
