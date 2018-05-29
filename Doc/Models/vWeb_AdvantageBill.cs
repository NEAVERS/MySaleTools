using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class vWeb_AdvantageBill
    {
        public decimal BillNumberID { get; set; }
        public string Serial { get; set; }
        public string typeid { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string StandardCode { get; set; }
        public string StandardName { get; set; }
        public int type { get; set; }
        public string standardtype { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string Comment { get; set; }
        public string Base { get; set; }
        public Nullable<long> itemid { get; set; }
        public Nullable<int> IsCombined { get; set; }
        public string itemname { get; set; }
        public string customitemid { get; set; }
        public string customitemfrom { get; set; }
        public string customitemname { get; set; }
        public string customitemrefid { get; set; }
        public int ID { get; set; }
        public string GoodsNumber { get; set; }
    }
}
