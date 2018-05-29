using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_Voucher_Bill_CashMoneyItems
    {
        public int nId { get; set; }
        public Nullable<decimal> BillNumberId { get; set; }
        public string STypeId { get; set; }
        public string MATypeId { get; set; }
        public string DATypeId { get; set; }
        public Nullable<int> FDc { get; set; }
        public Nullable<int> FAdc { get; set; }
        public Nullable<int> RowNo { get; set; }
        public Nullable<int> Cid { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> TotalFor { get; set; }
        public string FYear { get; set; }
        public Nullable<int> FPeriod { get; set; }
    }
}
