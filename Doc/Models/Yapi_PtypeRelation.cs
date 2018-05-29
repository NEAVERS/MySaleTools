using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Yapi_PtypeRelation
    {
        public int ID { get; set; }
        public string Ptypeid { get; set; }
        public Nullable<decimal> OnLineID { get; set; }
        public Nullable<decimal> SkuId { get; set; }
    }
}
