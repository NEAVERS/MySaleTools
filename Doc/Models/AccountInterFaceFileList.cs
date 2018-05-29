using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AccountInterFaceFileList
    {
        public int FileID { get; set; }
        public string FileName { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string ETypeID { get; set; }
        public string ContentType { get; set; }
        public Nullable<int> FileSize { get; set; }
        public byte[] BinaryData { get; set; }
        public string Memo { get; set; }
    }
}
