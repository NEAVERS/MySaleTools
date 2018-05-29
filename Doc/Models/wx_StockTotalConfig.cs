using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class wx_StockTotalConfig
    {
        public int ID { get; set; }
        public string ETypeId { get; set; }
        public string BillTypes { get; set; }
        public string ShowBdPType { get; set; }
        public string ShowSum { get; set; }
    }
}
