using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CommissionBillNewDetail
    {
        public decimal BillNumberId { get; set; }
        public decimal ID { get; set; }
        public string EtypeID { get; set; }
        public string DtypeID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> CommissionTotal { get; set; }
        public string Comment { get; set; }
        public Nullable<int> ShowOrder { get; set; }
    }
}
