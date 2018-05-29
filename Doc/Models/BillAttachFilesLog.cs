using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class BillAttachFilesLog
    {
        public decimal BillNumberId { get; set; }
        public int ID { get; set; }
        public Nullable<System.DateTime> OperateDate { get; set; }
        public string ETypeId { get; set; }
        public string logtype { get; set; }
        public string FileName { get; set; }
        public string FileSize { get; set; }
        public string FileComment { get; set; }
        public string FileUpEtype { get; set; }
        public Nullable<System.DateTime> FileUpTime { get; set; }
        public string BillGuid { get; set; }
        public Nullable<int> BillIndexType { get; set; }
        public Nullable<int> BillType { get; set; }
    }
}
