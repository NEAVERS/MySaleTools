using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class vWeb_GatheringPay_SaleBuy
    {
        public System.DateTime BillDate { get; set; }
        public string BillCode { get; set; }
        public Nullable<decimal> NCompleteTotal { get; set; }
        public decimal BillType { get; set; }
        public int GoodsBillID { get; set; }
        public int MoneyBillID { get; set; }
        public string FullName { get; set; }
        public string ETypeID { get; set; }
        public Nullable<byte> Draft { get; set; }
        public Nullable<int> GoodsBillDetailID { get; set; }
        public Nullable<int> ifYearBill { get; set; }
    }
}
