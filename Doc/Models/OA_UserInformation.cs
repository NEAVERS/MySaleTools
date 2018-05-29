using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OA_UserInformation
    {
        public int ID { get; set; }
        public string ETypeID_UserTypeID { get; set; }
        public int Experience { get; set; }
        public Nullable<int> Add { get; set; }
        public Nullable<int> Reply { get; set; }
    }
}
