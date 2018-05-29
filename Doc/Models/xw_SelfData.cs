using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class xw_SelfData
    {
        public int C_Id { get; set; }
        public int DataTypeId { get; set; }
        public string TypeId { get; set; }
        public string ParTypeId { get; set; }
        public int level { get; set; }
        public int SonNum { get; set; }
        public int SonCount { get; set; }
        public string FullName { get; set; }
        public string UserCode { get; set; }
        public string PyCode { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public string Field4 { get; set; }
        public bool Deleted { get; set; }
        public Nullable<decimal> XiWaMaxNumber { get; set; }
        public byte[] PosDataVersion { get; set; }
    }
}
