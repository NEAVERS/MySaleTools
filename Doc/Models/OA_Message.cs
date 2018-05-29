using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OA_Message
    {
        public int ID { get; set; }
        public string CatalogID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string ETypeID_SenderTypeID { get; set; }
        public string ETypeID_ReceiverTypeID { get; set; }
        public string ETypeID_CreatorTypeID { get; set; }
        public int AttachmentID { get; set; }
        public int IsRead { get; set; }
        public string Type { get; set; }
        public int Docking { get; set; }
        public int SortOrder { get; set; }
        public string MessageType { get; set; }
        public string InviteURL { get; set; }
    }
}
