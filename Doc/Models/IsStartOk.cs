using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class IsStartOk
    {
        public string typeID { get; set; }
        public string parID { get; set; }
        public Nullable<int> level { get; set; }
        public Nullable<int> sonnum { get; set; }
        public Nullable<int> soncount { get; set; }
        public Nullable<bool> delete { get; set; }
        public string userID { get; set; }
        public string stypeID { get; set; }
        public int isOpen { get; set; }
    }
}
