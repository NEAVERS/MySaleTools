using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class wx_ErrDescription
    {
        public decimal ID { get; set; }
        public string ErrCode { get; set; }
        public string ErrName { get; set; }
        public string ErrPyCode { get; set; }
        public string ErrDes { get; set; }
        public string ErrDeal { get; set; }
        public string ErrComment { get; set; }
        public Nullable<decimal> Total { get; set; }
    }
}
