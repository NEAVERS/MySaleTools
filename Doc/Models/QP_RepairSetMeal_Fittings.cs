using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class QP_RepairSetMeal_Fittings
    {
        public string TypeID { get; set; }
        public string PTypeID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> Total { get; set; }
    }
}
