using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SerialAdjustIndex
    {
        public decimal BillNumberId { get; set; }
        public System.DateTime BillDate { get; set; }
        public string BillCode { get; set; }
        public decimal BillType { get; set; }
        public string Comment { get; set; }
        public string btypeid { get; set; }
        public string dtypeid { get; set; }
        public string etypeid { get; set; }
        public string ktypeid { get; set; }
        public string ktypeid2 { get; set; }
        public string ifcheck { get; set; }
        public string checke { get; set; }
        public Nullable<decimal> totalqty { get; set; }
        public Nullable<short> period { get; set; }
        public string explain { get; set; }
        public int RedWord { get; set; }
        public bool draft { get; set; }
        public string Poster { get; set; }
        public string Stypeid { get; set; }
        public Nullable<System.DateTime> LastUpdateTime { get; set; }
    }
}
