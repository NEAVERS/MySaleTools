using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SchemeConfig
    {
        public decimal ID { get; set; }
        public decimal SchemeID { get; set; }
        public string IP { get; set; }
        public string Port { get; set; }
        public string instancename { get; set; }
        public string ConName { get; set; }
        public string ConPwd { get; set; }
        public string DbName { get; set; }
        public Nullable<int> IsDefault { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string CreateID { get; set; }
    }
}
