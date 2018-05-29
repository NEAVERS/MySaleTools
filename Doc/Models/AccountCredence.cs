using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AccountCredence
    {
        public decimal BillNumberID { get; set; }
        public string TypeATypeID { get; set; }
        public string ATypeID { get; set; }
        public Nullable<decimal> J_Total { get; set; }
        public Nullable<decimal> D_Total { get; set; }
        public string Comment { get; set; }
        public Nullable<int> TeamNo { get; set; }
        public Nullable<int> TeamNo1 { get; set; }
        public int ID { get; set; }
        public string Stypeid { get; set; }
        public Nullable<decimal> NJ_Total { get; set; }
        public Nullable<decimal> ND_Total { get; set; }
        public Nullable<int> CID { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public int AlertDay { get; set; }
    }
}
