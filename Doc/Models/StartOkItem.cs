using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class StartOkItem
    {
        public string typeID { get; set; }
        public string parID { get; set; }
        public Nullable<int> level { get; set; }
        public Nullable<int> sonnum { get; set; }
        public Nullable<int> soncount { get; set; }
        public Nullable<bool> delete { get; set; }
        public int ID { get; set; }
        public string itemsName { get; set; }
        public int partNameID { get; set; }
        public int SortID { get; set; }
        public int import { get; set; }
        public string otherItemsName { get; set; }
        public string expain { get; set; }
        public int Complete { get; set; }
        public string LimitScan { get; set; }
        public string LimitExport { get; set; }
    }
}
