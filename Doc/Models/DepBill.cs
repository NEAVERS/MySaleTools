using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class DepBill
    {
        public int Id { get; set; }
        public int BillNumberId { get; set; }
        public int AssetCardId { get; set; }
        public Nullable<decimal> Depreciation { get; set; }
        public string Comment { get; set; }
        public Nullable<decimal> WorkTime { get; set; }
        public string WorkUnit { get; set; }
    }
}
