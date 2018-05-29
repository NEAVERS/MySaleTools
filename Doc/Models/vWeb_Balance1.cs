using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class vWeb_Balance1
    {
        public decimal BillType { get; set; }
        public string btypeid { get; set; }
        public string etypeid { get; set; }
        public string ktypeid { get; set; }
        public string ktypeid2 { get; set; }
        public string bUserCode { get; set; }
        public string bFullName { get; set; }
        public decimal BillNumberId { get; set; }
        public System.DateTime BillDate { get; set; }
        public string BillCode { get; set; }
        public string EFullName { get; set; }
        public Nullable<decimal> unCompleteTotal { get; set; }
        public Nullable<decimal> preferencemoney { get; set; }
        public Nullable<decimal> completetotal { get; set; }
        public Nullable<decimal> totalinmoney { get; set; }
        public string IfStopMoney { get; set; }
    }
}
