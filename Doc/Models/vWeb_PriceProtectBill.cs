using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class vWeb_PriceProtectBill
    {
        public decimal BillNumberID { get; set; }
        public string typeid { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public Nullable<decimal> Oldtotal { get; set; }
        public string Serial { get; set; }
        public Nullable<decimal> OldPrice { get; set; }
        public Nullable<decimal> NewPrice { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> ntotal { get; set; }
        public string Comment { get; set; }
        public string Base { get; set; }
        public Nullable<long> itemid { get; set; }
        public Nullable<int> IsCombined { get; set; }
        public string itemname { get; set; }
        public string customitemid { get; set; }
        public string customitemfrom { get; set; }
        public string customitemname { get; set; }
        public string customitemrefid { get; set; }
        public string goodsnumber { get; set; }
        public int ID { get; set; }
        public Nullable<int> IfUseGoodsNum { get; set; }
    }
}
