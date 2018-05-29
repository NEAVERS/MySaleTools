using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Pos_AdvertisementPic
    {
        public Nullable<int> posid { get; set; }
        public byte[] pic { get; set; }
        public string uniquename { get; set; }
        public int ORDERID { get; set; }
        public string imgtype { get; set; }
        public string imgname { get; set; }
        public string random { get; set; }
        public System.DateTime updatetime { get; set; }
    }
}
