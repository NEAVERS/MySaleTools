using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OA_Subscibe
    {
        public int ID { get; set; }
        public Nullable<int> ArticleID { get; set; }
        public string ETypeID_SubsciberTypeID { get; set; }
    }
}
