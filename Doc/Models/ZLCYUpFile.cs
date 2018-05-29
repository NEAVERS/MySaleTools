using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ZLCYUpFile
    {
        public string BBSID { get; set; }
        public int ID { get; set; }
        public string FileName { get; set; }
        public string Comment { get; set; }
        public byte[] BinaryContent { get; set; }
        public string ContentType { get; set; }
        public Nullable<int> ContentLength { get; set; }
        public string szDate { get; set; }
    }
}
