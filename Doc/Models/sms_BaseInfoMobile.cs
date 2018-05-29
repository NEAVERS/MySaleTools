using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class sms_BaseInfoMobile
    {
        public int Id { get; set; }
        public Nullable<int> nType { get; set; }
        public string TypeID { get; set; }
        public string Mobile { get; set; }
        public string Comment { get; set; }
    }
}
