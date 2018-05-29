using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class NVipCardSetLog
    {
        public int iD { get; set; }
        public Nullable<System.DateTime> updateTime { get; set; }
        public string etypeid { get; set; }
        public Nullable<int> VipCardTypeID { get; set; }
        public Nullable<int> ChangeType { get; set; }
        public string comment { get; set; }
    }
}
