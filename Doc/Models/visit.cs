using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class visit
    {
        public decimal billnumberid { get; set; }
        public System.DateTime billdate { get; set; }
        public string billcode { get; set; }
        public string etypeid { get; set; }
        public decimal jbbillnumberid { get; set; }
        public string btypeid { get; set; }
        public string fullname { get; set; }
        public string linkman { get; set; }
        public string linktel { get; set; }
        public string linkaddr { get; set; }
        public Nullable<System.DateTime> inbilldate { get; set; }
        public string inbillcode { get; set; }
        public string manyidu { get; set; }
        public string jianyi { get; set; }
        public Nullable<decimal> fjid { get; set; }
    }
}
