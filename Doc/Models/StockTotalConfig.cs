using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class StockTotalConfig
    {
        public int ID { get; set; }
        public string ETypeId { get; set; }
        public string BillTypes { get; set; }
        public string ShowMoney { get; set; }
        public string ShowBdPType { get; set; }
        public string ShowSum { get; set; }
    }
}
