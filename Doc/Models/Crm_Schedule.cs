using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Crm_Schedule
    {
        public int ID { get; set; }
        public string TYPE { get; set; }
        public string CreatorTypeID { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> AlterDate { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string IsAlert { get; set; }
        public string ViewEtypeIDS { get; set; }
    }
}
