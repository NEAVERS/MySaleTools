using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class DepPlanBill
    {
        public int Id { get; set; }
        public int PlanId { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<int> Month { get; set; }
        public Nullable<decimal> NDepMoney { get; set; }
        public Nullable<decimal> DepMoney { get; set; }
        public Nullable<decimal> NDepTotal { get; set; }
        public Nullable<decimal> DepTotal { get; set; }
        public Nullable<decimal> NNetValue { get; set; }
        public Nullable<decimal> NetValue { get; set; }
    }
}
