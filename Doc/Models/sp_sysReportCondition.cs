using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class sp_sysReportCondition
    {
        public int ID { get; set; }
        public Nullable<int> sp_Id { get; set; }
        public string funName { get; set; }
        public Nullable<int> orderId { get; set; }
        public Nullable<int> sortId { get; set; }
    }
}
