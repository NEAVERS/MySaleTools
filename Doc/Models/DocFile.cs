using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class DocFile
    {
        public decimal Id { get; set; }
        public string pathId { get; set; }
        public string FullName { get; set; }
        public decimal FileSize { get; set; }
        public string FileType { get; set; }
        public byte[] Binarydata { get; set; }
        public System.DateTime UploadDate { get; set; }
        public string etypeid { get; set; }
        public string xpsFileName { get; set; }
    }
}
