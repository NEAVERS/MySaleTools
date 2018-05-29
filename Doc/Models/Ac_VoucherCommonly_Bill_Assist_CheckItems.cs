using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_VoucherCommonly_Bill_Assist_CheckItems
    {
        public int nId { get; set; }
        public Nullable<int> BillNumberId { get; set; }
        public Nullable<int> vBId { get; set; }
        public string typeName { get; set; }
        public string TypeId { get; set; }
    }
}
