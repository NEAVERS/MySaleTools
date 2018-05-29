using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OM_Order
    {
        public int Id { get; set; }
        public string SerialNo { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> TotalMoney { get; set; }
        public string Comment { get; set; }
        public byte Status { get; set; }
        public string BtypeId { get; set; }
        public string BtypeName { get; set; }
        public int CreatorId { get; set; }
        public string CreatorName { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public int ModifierId { get; set; }
        public string ModifierName { get; set; }
        public System.DateTime ModifiedTime { get; set; }
        public Nullable<decimal> PreferenceMoney { get; set; }
        public int bid { get; set; }
    }
}
