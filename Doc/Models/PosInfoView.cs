using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PosInfoView
    {
        public string PosID { get; set; }
        public string FullName { get; set; }
        public string UserCode { get; set; }
        public string Branchid { get; set; }
        public string Etypeid { get; set; }
        public string stockid { get; set; }
        public string Btypeid { get; set; }
        public int Deleted { get; set; }
        public int isKeySet { get; set; }
        public int IsHeadquartersStock { get; set; }
        public int IsJoinStock { get; set; }
        public string PosPassword { get; set; }
        public int Possessive { get; set; }
        public string Comment { get; set; }
        public int IsTicketCount { get; set; }
        public string cBYZD1 { get; set; }
        public string cBYZD2 { get; set; }
        public int iBYZD1 { get; set; }
        public int iBYZD2 { get; set; }
        public int nBYZD1 { get; set; }
        public int nBYZD2 { get; set; }
    }
}
