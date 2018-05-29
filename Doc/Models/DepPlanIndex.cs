using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class DepPlanIndex
    {
        public int Id { get; set; }
        public int BillNumberId { get; set; }
        public int AssetCardId { get; set; }
        public int DepType { get; set; }
        public int Cid { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<int> Flag { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
    }
}
