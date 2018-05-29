using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class GiveFromSaleOrBuy
    {
        public int ID { get; set; }
        public Nullable<int> SourceBillNumberId { get; set; }
        public Nullable<int> DestBillNumberId { get; set; }
        public string IfCheck { get; set; }
        public string ETypeID { get; set; }
        public string BTypeID { get; set; }
        public string KTypeID { get; set; }
        public string Explain { get; set; }
        public string Comment { get; set; }
    }
}
