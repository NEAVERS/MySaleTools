using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class QP_nVipCardSign_RemindEvent
    {
        public int VipCardID { get; set; }
        public int ID { get; set; }
        public string RemindContent { get; set; }
        public System.DateTime RemindDate { get; set; }
        public string Comment { get; set; }
    }
}
