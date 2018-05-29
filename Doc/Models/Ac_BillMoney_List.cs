using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_BillMoney_List
    {
        public int BillMoneyId { get; set; }
        public Nullable<int> BillType { get; set; }
        public string FullName { get; set; }
        public string Express { get; set; }
        public string Content { get; set; }
        public int Sysrow { get; set; }
    }
}
