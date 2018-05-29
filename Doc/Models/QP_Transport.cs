using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class QP_Transport
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string UserCode { get; set; }
        public string PYCode { get; set; }
        public string BTypeID { get; set; }
        public string Comment { get; set; }
    }
}
