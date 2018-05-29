using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OM_LoginUsers
    {
        public int TypeID { get; set; }
        public string BtypeID { get; set; }
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> Level { get; set; }
        public string TelePhone { get; set; }
        public string QQ { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
        public string Lim { get; set; }
        public string Password { get; set; }
    }
}
