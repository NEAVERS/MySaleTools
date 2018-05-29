using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PosPtypeView
    {
        public string Ptypeid { get; set; }
        public string batchNumber { get; set; }
        public string WareNumber { get; set; }
        public string Parid { get; set; }
        public short Leveal { get; set; }
        public int Sonnum { get; set; }
        public int soncount { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public string standard { get; set; }
        public string type { get; set; }
        public string area { get; set; }
        public string unit { get; set; }
        public int relprice { get; set; }
        public int retailprice { get; set; }
        public bool Deleted { get; set; }
        public int stop { get; set; }
        public Nullable<short> stopdate { get; set; }
        public string IssueDate { get; set; }
        public Nullable<decimal> UpdateTag { get; set; }
        public string cBYZD1 { get; set; }
        public string cBYZD2 { get; set; }
        public int iBYZD1 { get; set; }
        public int iBYZD2 { get; set; }
        public int nBYZD1 { get; set; }
        public int nBYZD2 { get; set; }
    }
}
