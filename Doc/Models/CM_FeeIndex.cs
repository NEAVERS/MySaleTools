using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CM_FeeIndex
    {
        public decimal BillNumberId { get; set; }
        public System.DateTime BillDate { get; set; }
        public string BillCode { get; set; }
        public decimal BillType { get; set; }
        public string Comment { get; set; }
        public int CarId { get; set; }
        public string Stypeid { get; set; }
        public string Etypeid { get; set; }
        public string Dtypeid { get; set; }
        public Nullable<decimal> Totalmoney { get; set; }
        public string checke { get; set; }
        public string Explain { get; set; }
    }
}
