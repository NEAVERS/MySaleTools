using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PosBtypeView
    {
        public string branchid { get; set; }
        public string btypeid { get; set; }
        public string parid { get; set; }
        public short leveal { get; set; }
        public int soncount { get; set; }
        public int sonnum { get; set; }
        public string usercode { get; set; }
        public string fullname { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int PriceTypeId { get; set; }
        public Nullable<decimal> updatetag { get; set; }
        public string cBYZD1 { get; set; }
        public string cBYZD2 { get; set; }
        public int iBYZD1 { get; set; }
        public int iBYZD2 { get; set; }
        public int nBYZD1 { get; set; }
        public int nBYZD2 { get; set; }
    }
}
