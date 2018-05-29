using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PerformanceDistribution
    {
        public decimal BillNumberId { get; set; }
        public int ID { get; set; }
        public string PTypeID { get; set; }
        public string ETypeID { get; set; }
        public Nullable<decimal> Proportion { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string Checke { get; set; }
        public string Comment { get; set; }
        public Nullable<decimal> DiscountTotal { get; set; }
        public Nullable<decimal> CostTotal { get; set; }
        public int IsPtype { get; set; }
        public string BillComment { get; set; }
        public string pid { get; set; }
    }
}
