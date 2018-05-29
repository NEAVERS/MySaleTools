using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class EshopBillRelation
    {
        public int Id { get; set; }
        public string EshopBillID { get; set; }
        public Nullable<decimal> Billnumberid { get; set; }
        public Nullable<int> Flag { get; set; }
    }
}
