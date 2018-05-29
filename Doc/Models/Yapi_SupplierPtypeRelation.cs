using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Yapi_SupplierPtypeRelation
    {
        public int ID { get; set; }
        public Nullable<decimal> SupplierID { get; set; }
        public Nullable<decimal> OnLineID { get; set; }
        public string OnLineFullname { get; set; }
        public string OnLineUserCode { get; set; }
        public string Ptypeid { get; set; }
        public Nullable<decimal> SkuId { get; set; }
    }
}
