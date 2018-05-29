using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PosStockView
    {
        public string branchid { get; set; }
        public string Ktypeid { get; set; }
        public string parid { get; set; }
        public short leveal { get; set; }
        public int sonnum { get; set; }
        public int soncount { get; set; }
        public string fullname { get; set; }
        public string name { get; set; }
        public string usercode { get; set; }
        public int PriceTypeID { get; set; }
        public bool deleted { get; set; }
        public Nullable<decimal> updatetag { get; set; }
        public string cBYZD { get; set; }
        public int iBYZD { get; set; }
    }
}
