using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class vWeb_SaleBuy_GatheringPay
    {
        public System.DateTime BillDate { get; set; }
        public string BillCode { get; set; }
        public Nullable<decimal> totalinmoney { get; set; }
        public Nullable<decimal> NTotalInMoney { get; set; }
        public Nullable<decimal> CompleteTotal { get; set; }
        public Nullable<decimal> NCompleteTotal { get; set; }
        public decimal BillType { get; set; }
        public Nullable<int> jsbilltype { get; set; }
        public int GoodsBillID { get; set; }
        public int MoneyBillID { get; set; }
        public Nullable<byte> Draft { get; set; }
        public Nullable<int> GoodsBillDetailID { get; set; }
        public Nullable<int> ifYearBill { get; set; }
        public Nullable<int> ComBillType { get; set; }
    }
}
