using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OA_Right
    {
        public int ID { get; set; }
        public string ETypeID_EmployeeTypeID { get; set; }
        public string CatalogID { get; set; }
        public string RightString { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ETypeID_ModifierTypeID { get; set; }
    }
}
