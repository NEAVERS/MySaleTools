using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class QP_ChargingStandards
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public Nullable<decimal> ManHourRate { get; set; }
        public int IfDefault { get; set; }
        public string PYCode { get; set; }
    }
}
