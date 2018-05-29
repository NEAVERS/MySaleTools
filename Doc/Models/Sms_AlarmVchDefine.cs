using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Sms_AlarmVchDefine
    {
        public int ID { get; set; }
        public Nullable<int> VchType { get; set; }
        public string VchName { get; set; }
        public string Comment { get; set; }
    }
}
