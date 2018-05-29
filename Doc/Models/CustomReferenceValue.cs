using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CustomReferenceValue
    {
        public long id { get; set; }
        public long itemsid { get; set; }
        public string ReferenId { get; set; }
        public string Fullname { get; set; }
        public byte[] PosDataVersion { get; set; }
        public Nullable<decimal> XiWaMaxNumber { get; set; }
    }
}
