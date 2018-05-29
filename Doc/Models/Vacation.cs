using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Vacation
    {
        public decimal Id { get; set; }
        public string Fullname { get; set; }
        public string STypeID { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
    }
}
