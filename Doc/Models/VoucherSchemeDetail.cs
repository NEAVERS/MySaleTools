using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class VoucherSchemeDetail
    {
        public int nId { get; set; }
        public int SchemeId { get; set; }
        public string OrderFiled { get; set; }
        public string OrderBy { get; set; }
        public int OrderID { get; set; }
    }
}
