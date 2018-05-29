using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_GoodsBill_VoucherBill
    {
        public int Agvbid { get; set; }
        public Nullable<decimal> GoodsBillId { get; set; }
        public Nullable<decimal> VourchBillId { get; set; }
        public Nullable<int> AtId { get; set; }
        public Nullable<int> InOutType { get; set; }
    }
}
