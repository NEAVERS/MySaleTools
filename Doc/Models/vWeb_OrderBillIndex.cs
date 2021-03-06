using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class vWeb_OrderBillIndex
    {
        public decimal billNumberId { get; set; }
        public string BName { get; set; }
        public System.DateTime BillDate { get; set; }
        public string Billcode { get; set; }
        public Nullable<decimal> totalmoney { get; set; }
        public Nullable<decimal> totalqty { get; set; }
        public string comment { get; set; }
        public Nullable<int> IfAudit { get; set; }
        public string EName1 { get; set; }
        public string PostCode { get; set; }
        public string TelAndAddress { get; set; }
        public Nullable<System.DateTime> ReachDate { get; set; }
        public string WayMode { get; set; }
        public string BillStatus { get; set; }
        public string KName { get; set; }
        public string btypeid { get; set; }
        public string etypeid { get; set; }
        public string ktypeid { get; set; }
        public string dtypeid { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public string busercode { get; set; }
        public string saleprice { get; set; }
        public string buyprice { get; set; }
        public string eusercode { get; set; }
        public string kusercode { get; set; }
        public string dusercode { get; set; }
        public string DName { get; set; }
        public short billtype { get; set; }
        public string EName2 { get; set; }
        public string explain { get; set; }
        public string WayBillCode { get; set; }
        public string GoodsNumber { get; set; }
        public string PackWay { get; set; }
        public string TEL { get; set; }
        public Nullable<int> IsFinished { get; set; }
        public string OrderState { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> ReachQty { get; set; }
        public decimal ARLimitTime { get; set; }
        public decimal PaymentLTime { get; set; }
        public string BillDetail { get; set; }
        public string stypeid { get; set; }
        public string SName { get; set; }
    }
}
