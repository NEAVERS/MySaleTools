using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class HR_PersonWorkExp
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
        public string Company { get; set; }
        public string Department { get; set; }
        public string Job { get; set; }
        public string DimissionReason { get; set; }
        public string ProvePerson { get; set; }
        public string CompanyPhone { get; set; }
    }
}
