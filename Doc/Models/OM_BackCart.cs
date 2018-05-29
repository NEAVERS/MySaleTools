using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OM_BackCart
    {
        public int Id { get; set; }
        public string CommodityId { get; set; }
        public string CommodityName { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> DiscountPrice { get; set; }
        public Nullable<decimal> TotalMoney { get; set; }
        public Nullable<decimal> SaleMoney { get; set; }
        public int UnitID { get; set; }
        public string UnitName { get; set; }
        public int InventoryInfoId { get; set; }
        public string BtypeId { get; set; }
        public string BtypeName { get; set; }
        public string Comment { get; set; }
        public int CreatorId { get; set; }
        public string CreatorName { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public int ModifierId { get; set; }
        public string ModifierName { get; set; }
        public System.DateTime ModifiedTime { get; set; }
        public int OrderIndexId { get; set; }
        public int OrderId { get; set; }
        public decimal pid { get; set; }
    }
}
