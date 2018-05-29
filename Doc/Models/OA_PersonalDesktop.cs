using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OA_PersonalDesktop
    {
        public int ID { get; set; }
        public string ETypeID_CreatorTypeID { get; set; }
        public string CatalogTypeID { get; set; }
        public int SortOrder { get; set; }
        public int DesktopList { get; set; }
        public int Notify { get; set; }
        public int ReplyNotify { get; set; }
        public int RefusePassiveReplyNotify { get; set; }
    }
}
