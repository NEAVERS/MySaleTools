using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class QP_nVipCardSet_RepairItems_
    {
        public int VipCardTypeID { get; set; }
        public int ID { get; set; }
        public string RepairItemsTypeID { get; set; }
        public int RepairItemsType { get; set; }
        public Nullable<decimal> ManHour { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> VIPPrice { get; set; }
        public int AllowUsedTimes { get; set; }
        public string Comment { get; set; }
    }
}
