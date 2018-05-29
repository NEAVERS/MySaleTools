using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PosDataUpdated
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> UpdateDateTime { get; set; }
        public string UpdateDataList { get; set; }
        public string AllDataList { get; set; }
        public string stypeid { get; set; }
        public string folder { get; set; }
    }
}
