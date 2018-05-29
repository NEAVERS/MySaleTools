using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SaleTimeTotal
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Years { get; set; }
        public string Comment { get; set; }
        public Nullable<bool> IfAudit { get; set; }
        public Nullable<byte> IfUse { get; set; }
    }
}
