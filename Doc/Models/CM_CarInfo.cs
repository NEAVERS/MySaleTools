using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CM_CarInfo
    {
        public int TypeId { get; set; }
        public string Platenumber { get; set; }
        public string Cartype { get; set; }
        public Nullable<System.DateTime> Receptiondate { get; set; }
        public string Driver { get; set; }
    }
}
