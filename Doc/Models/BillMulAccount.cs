using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class BillMulAccount
    {
        public decimal BillNumberId { get; set; }
        public int ID { get; set; }
        public string ATypeID { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string Comment { get; set; }
        public Nullable<int> VipCardID { get; set; }
        public Nullable<decimal> NTotalMoney { get; set; }
        public decimal paymoney { get; set; }
    }
}
