using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Qp_YearCheck
    {
        public decimal YearCheckId { get; set; }
        public string RaTypeID { get; set; }
        public string STypeID { get; set; }
        public string YearCheckNo { get; set; }
        public Nullable<decimal> YearCheckTotal { get; set; }
        public Nullable<System.DateTime> YearCheckDate { get; set; }
        public Nullable<System.DateTime> ReachDate { get; set; }
        public string Comment { get; set; }
        public string Mobile { get; set; }
    }
}
