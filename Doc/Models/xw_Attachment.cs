using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class xw_Attachment
    {
        public int C_Id { get; set; }
        public Nullable<System.Guid> Guid { get; set; }
        public Nullable<System.Guid> OwnerGuid { get; set; }
        public Nullable<int> OwnerId { get; set; }
        public byte[] Content { get; set; }
        public string Filename { get; set; }
        public string Comment { get; set; }
        public System.DateTime CreationTime { get; set; }
        public System.DateTime LastModifiedTime { get; set; }
        public bool Deleted { get; set; }
    }
}
