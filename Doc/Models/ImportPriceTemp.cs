using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ImportPriceTemp
    {
        public string etypeid { get; set; }
        public string typeid { get; set; }
        public string usercode { get; set; }
        public string fullname { get; set; }
        public Nullable<long> itemid { get; set; }
        public string itemname { get; set; }
        public Nullable<byte> iscombined { get; set; }
        public string munit { get; set; }
        public Nullable<int> munitid { get; set; }
        public Nullable<decimal> munitrate { get; set; }
        public Nullable<int> baojiamode { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<decimal> discount { get; set; }
        public Nullable<decimal> curmdiscountprice { get; set; }
        public Nullable<bool> xianjiamode { get; set; }
        public string comment { get; set; }
        public Nullable<bool> deleted { get; set; }
        public Nullable<System.DateTime> importtime { get; set; }
        public Nullable<decimal> tax { get; set; }
        public Nullable<decimal> curmtaxprice { get; set; }
    }
}
