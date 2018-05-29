using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class sp_sysReportCondition_Item
    {
        public int ID { get; set; }
        public Nullable<int> sp_Id { get; set; }
        public Nullable<int> orderId { get; set; }
        public string paramValue { get; set; }
    }
}
