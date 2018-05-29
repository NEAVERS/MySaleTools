using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class QP_nVipCardSign_RepairItems_
    {
        public int VipCardID { get; set; }
        public int ID { get; set; }
        public string RepairItemsTypeID { get; set; }
        public Nullable<decimal> ManHour { get; set; }
        public Nullable<decimal> VIPPrice { get; set; }
        public int AllowUsedTimes { get; set; }
        public int UsedTimes { get; set; }
        public string Comment { get; set; }
    }
}
