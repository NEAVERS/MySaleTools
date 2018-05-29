using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Pos_UploadDogInfo
    {
        public long Id { get; set; }
        public string dognumber { get; set; }
        public string posname { get; set; }
        public Nullable<int> eid { get; set; }
        public Nullable<int> billcount { get; set; }
        public System.DateTime logtime { get; set; }
        public Nullable<System.DateTime> uploadtime { get; set; }
        public string IsUpload { get; set; }
    }
}
