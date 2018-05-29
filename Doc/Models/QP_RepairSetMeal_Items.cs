using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class QP_RepairSetMeal_Items
    {
        public string RepairItemsTypeID { get; set; }
        public string TypeID { get; set; }
        public Nullable<decimal> StandardManHour { get; set; }
        public Nullable<decimal> CheckManHour { get; set; }
        public Nullable<decimal> ManHourExpense { get; set; }
    }
}
