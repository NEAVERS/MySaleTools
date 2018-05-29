using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PosLoginUserView
    {
        public string etypeid { get; set; }
        public string Password { get; set; }
        public string SysID { get; set; }
        public int MinDiscount { get; set; }
        public string KeyNo { get; set; }
        public string SendID { get; set; }
        public Nullable<bool> LockID { get; set; }
        public Nullable<int> LockLevel { get; set; }
    }
}
