using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class vWeb_ARAPIndex
    {
        public string BillCode { get; set; }
        public decimal BillNumberId { get; set; }
        public System.DateTime BillDate { get; set; }
        public string etypeid { get; set; }
        public string btypeid { get; set; }
        public decimal BillType { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> totalinmoney { get; set; }
        public string Comment { get; set; }
        public string atypeid { get; set; }
        public Nullable<int> TeamNo { get; set; }
        public int RedWord { get; set; }
    }
}
