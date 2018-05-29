using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_Voucher_Bill
    {
        public Nullable<decimal> BillNumberId { get; set; }
        public string Summary { get; set; }
        public string STypeId { get; set; }
        public string ATypeId { get; set; }
        public string ATypeId2 { get; set; }
        public Nullable<int> Fdc { get; set; }
        public string F_ExchId { get; set; }
        public string F_ExchIdFor { get; set; }
        public Nullable<decimal> FDebitTotal { get; set; }
        public Nullable<decimal> FDebitTotalFor { get; set; }
        public Nullable<decimal> FCreditTotal { get; set; }
        public Nullable<decimal> FCreditTotalFor { get; set; }
        public decimal ID { get; set; }
        public Nullable<decimal> OldID { get; set; }
        public Nullable<int> FCashFlowItem { get; set; }
        public string AscIds { get; set; }
        public string FSettleNo { get; set; }
        public Nullable<int> FSettleTypeID { get; set; }
        public Nullable<System.DateTime> FSettleDate { get; set; }
        public string FYear { get; set; }
        public Nullable<int> FPeriod { get; set; }
        public string Comment { get; set; }
        public Nullable<int> Cid { get; set; }
        public Nullable<int> RowNo { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<int> FAdc { get; set; }
    }
}
