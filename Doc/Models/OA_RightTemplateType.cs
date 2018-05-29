using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OA_RightTemplateType
    {
        public int ID { get; set; }
        public string TemplateName { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ETypeID_CreatorTypeID { get; set; }
    }
}
