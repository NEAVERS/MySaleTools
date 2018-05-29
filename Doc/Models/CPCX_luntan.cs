using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CPCX_luntan
    {
        public Nullable<int> New_Number { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public string Standard { get; set; }
        public string Type { get; set; }
        public string Area { get; set; }
        public string Unit { get; set; }
        public Nullable<decimal> SalePrice { get; set; }
        public string Manufacturer { get; set; }
        public string Comment { get; set; }
        public byte[] ImageFile { get; set; }
        public string FileType { get; set; }
        public string FileName { get; set; }
        public Nullable<int> FileLength { get; set; }
        public string szDate { get; set; }
        public string OpeatorID { get; set; }
        public Nullable<int> ClickNum { get; set; }
        public byte[] FJBinaryContent { get; set; }
        public string FJContentType { get; set; }
        public Nullable<int> FJContentLength { get; set; }
        public string FJFileName { get; set; }
    }
}
