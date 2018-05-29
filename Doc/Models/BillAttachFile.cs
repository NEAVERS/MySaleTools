using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class BillAttachFile
    {
        public decimal BillNumberId { get; set; }
        public int ID { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string Size { get; set; }
        public string Comment { get; set; }
        public string ETypeId { get; set; }
        public Nullable<System.DateTime> AttachDate { get; set; }
        public byte[] Data { get; set; }
        public Nullable<int> BillIndexType { get; set; }
        public string BillGuid { get; set; }
        public Nullable<int> BillType { get; set; }
    }
}
