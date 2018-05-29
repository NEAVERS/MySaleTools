using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OMBillAttachFile
    {
        public int ID { get; set; }
        public decimal BillNumberId { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string Size { get; set; }
        public System.DateTime AttachDate { get; set; }
        public string newname { get; set; }
        public byte[] Data { get; set; }
        public int BillIndexType { get; set; }
        public int bid { get; set; }
        public string operatorname { get; set; }
    }
}
