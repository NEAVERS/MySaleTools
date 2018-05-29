using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_Voucher_Temp
    {
        public string STypeId { get; set; }
        public Nullable<int> VgId { get; set; }
        public decimal BillNumberId { get; set; }
        public Nullable<System.DateTime> BillDate { get; set; }
        public Nullable<decimal> FlowNo { get; set; }
        public string FComment { get; set; }
        public Nullable<int> SbillType { get; set; }
        public Nullable<int> InOutType { get; set; }
    }
}
