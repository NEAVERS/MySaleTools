using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class VoucherTemplatePreset
    {
        public int Id { get; set; }
        public Nullable<int> Billtype { get; set; }
        public string usercode { get; set; }
        public string fullname { get; set; }
        public string groupfullname { get; set; }
        public string summary { get; set; }
        public string atypefrom { get; set; }
        public string atypeusercode { get; set; }
        public string atypefullname { get; set; }
        public string dc { get; set; }
        public string totalfrom { get; set; }
        public string assitems { get; set; }
        public Nullable<int> SubId { get; set; }
        public Nullable<int> AuditType { get; set; }
        public Nullable<int> InOutType { get; set; }
        public Nullable<int> ChargeOffType { get; set; }
        public Nullable<int> MainRow { get; set; }
    }
}
