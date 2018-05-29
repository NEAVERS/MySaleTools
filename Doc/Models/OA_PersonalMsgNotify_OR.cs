using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OA_PersonalMsgNotify_OR
    {
        public int ID { get; set; }
        public string ETypeID_CreatorTypeID { get; set; }
        public string CatalogTypeID { get; set; }
        public string PublisherTypeID { get; set; }
        public string PublisherName { get; set; }
        public string Content { get; set; }
        public System.DateTime ModifyDate { get; set; }
        public int Available { get; set; }
        public string Grammar { get; set; }
    }
}
