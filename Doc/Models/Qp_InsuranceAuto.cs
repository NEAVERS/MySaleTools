using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Qp_InsuranceAuto
    {
        public decimal InsuranceAutoId { get; set; }
        public string RaTypeID { get; set; }
        public string STypeID { get; set; }
        public string InsuranceName { get; set; }
        public Nullable<decimal> InsuranceTotal { get; set; }
        public Nullable<System.DateTime> ReachDate { get; set; }
        public string InsuranceNo { get; set; }
        public string CardNumber { get; set; }
        public string Comment { get; set; }
        public string Mobile { get; set; }
    }
}
