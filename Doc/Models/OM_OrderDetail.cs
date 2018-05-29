using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OM_OrderDetail
    {
        public int ID { get; set; }
        public Nullable<decimal> billNumberID { get; set; }
        public string ptypeid { get; set; }
        public Nullable<decimal> qty { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<decimal> taxprice { get; set; }
        public Nullable<decimal> tax { get; set; }
        public string comment { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> DiscountPrice { get; set; }
        public Nullable<decimal> SaleTotal { get; set; }
        public Nullable<int> UnitID { get; set; }
        public Nullable<long> ItemID { get; set; }
        public Nullable<int> IsCombined { get; set; }
        public Nullable<decimal> ReachQty { get; set; }
        public Nullable<decimal> ConfirmQty { get; set; }
        public Nullable<decimal> StopQty { get; set; }
        public Nullable<byte> STATUS { get; set; }
        public Nullable<int> InventoryInfoId { get; set; }
        public bool IsGift { get; set; }
        public decimal pid { get; set; }
    }
}
