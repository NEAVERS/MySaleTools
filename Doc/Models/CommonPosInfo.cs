using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CommonPosInfo
    {
        public string PosID { get; set; }
        public string FullName { get; set; }
        public string UserCode { get; set; }
        public string Branchid { get; set; }
        public string ETypeId { get; set; }
        public string Stockid { get; set; }
        public string BTypeId { get; set; }
        public int deleted { get; set; }
        public int IsKeyset { get; set; }
        public int IsHeadquartersStock { get; set; }
        public int IsJoinStock { get; set; }
        public string PosPassword { get; set; }
        public int Possessive { get; set; }
        public string Comment { get; set; }
        public int IsTicketCount { get; set; }
        public string cBYZD1 { get; set; }
        public string cBYZD2 { get; set; }
        public Nullable<int> iBYZD1 { get; set; }
        public Nullable<int> iBYZD2 { get; set; }
        public Nullable<decimal> nBYZD1 { get; set; }
        public Nullable<decimal> nBYZD2 { get; set; }
        public string ETypeid1 { get; set; }
    }
}
