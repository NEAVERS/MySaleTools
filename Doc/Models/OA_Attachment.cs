using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OA_Attachment
    {
        public int ID { get; set; }
        public Nullable<int> FatherID { get; set; }
        public string Type { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string ETypeID_CreatorTypeID { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public Nullable<int> FileSize { get; set; }
        public byte[] BinaryData { get; set; }
    }
}
