using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PosMulAccountAll
    {
        public int ID { get; set; }
        public int BillNumberId { get; set; }
        public Nullable<int> ATypeID { get; set; }
        public string PayStyle { get; set; }
        public Nullable<decimal> ATotal { get; set; }
        public Nullable<int> VipCardID { get; set; }
        public string Comment { get; set; }
        public decimal paymoney { get; set; }
    }
}
