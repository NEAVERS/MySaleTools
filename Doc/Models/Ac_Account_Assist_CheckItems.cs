using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_Account_Assist_CheckItems
    {
        public string STypeId { get; set; }
        public string ATypeId { get; set; }
        public Nullable<int> Cid { get; set; }
        public Nullable<int> Ascids { get; set; }
        public Nullable<int> IsRequired { get; set; }
        public string DTypeID { get; set; }
    }
}
