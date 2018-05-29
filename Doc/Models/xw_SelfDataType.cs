using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class xw_SelfDataType
    {
        public int C_Id { get; set; }
        public string Name { get; set; }
        public bool Deleted { get; set; }
        public Nullable<decimal> XiWaMaxNumber { get; set; }
        public byte[] PosDataVersion { get; set; }
    }
}
