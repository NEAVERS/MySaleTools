using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class KinOutStockConfig
    {
        public int ID { get; set; }
        public string ETypeId { get; set; }
        public string BillTypes { get; set; }
        public string Shownqty { get; set; }
        public string Showinstock { get; set; }
        public string Showoutstock { get; set; }
        public string Showstock { get; set; }
    }
}
