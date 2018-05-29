using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_MulColumnAccount
    {
        public string STypeid { get; set; }
        public string ATypeid { get; set; }
        public string AccountName { get; set; }
        public Nullable<int> Ascid { get; set; }
        public Nullable<int> flevel { get; set; }
        public int AssistID { get; set; }
        public string Cids { get; set; }
        public Nullable<int> Flag { get; set; }
        public string Creator { get; set; }
        public string CreatorStypeId { get; set; }
        public Nullable<bool> IsPublic { get; set; }
        public string Comment { get; set; }
    }
}
