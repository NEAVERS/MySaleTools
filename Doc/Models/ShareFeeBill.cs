using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ShareFeeBill
    {
        public decimal BillNumberId { get; set; }
        public int BillType { get; set; }
        public decimal FromBillNumberID { get; set; }
        public decimal FromBillID { get; set; }
        public int ID { get; set; }
        public string Comment { get; set; }
        public Nullable<int> ShowOrder { get; set; }
    }
}
