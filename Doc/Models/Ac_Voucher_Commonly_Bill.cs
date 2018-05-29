using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_Voucher_Commonly_Bill
    {
        public decimal ID { get; set; }
        public Nullable<decimal> BillNumberId { get; set; }
        public string Summary { get; set; }
        public string STypeId { get; set; }
        public string ATypeId { get; set; }
        public Nullable<int> Fdc { get; set; }
        public Nullable<int> FAdc { get; set; }
        public Nullable<decimal> FDebitTotal { get; set; }
        public Nullable<decimal> FCreditTotal { get; set; }
        public string FYear { get; set; }
        public Nullable<int> FPeriod { get; set; }
        public string Comment { get; set; }
        public Nullable<int> RowNo { get; set; }
        public string AscIds { get; set; }
    }
}
