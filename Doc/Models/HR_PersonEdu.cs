using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class HR_PersonEdu
    {
        public string typeID { get; set; }
        public string parID { get; set; }
        public Nullable<int> level { get; set; }
        public Nullable<int> sonnum { get; set; }
        public Nullable<int> soncount { get; set; }
        public Nullable<bool> delete { get; set; }
        public int ID { get; set; }
        public int Person_ID { get; set; }
        public string Date { get; set; }
        public string School { get; set; }
        public string Specialty { get; set; }
        public string Degree { get; set; }
    }
}
