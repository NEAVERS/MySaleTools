using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class VipCardSign
    {
        public int VipCardSignId { get; set; }
        public string VipCardNo { get; set; }
        public Nullable<int> VipCardId { get; set; }
        public Nullable<System.DateTime> SignDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string VipCardOwner { get; set; }
        public string CertificateNo { get; set; }
        public string LinkerPhoneNo { get; set; }
        public string LinkerAddr { get; set; }
        public string BTypeID { get; set; }
        public Nullable<int> VipCardState { get; set; }
        public Nullable<decimal> VipCardZK { get; set; }
        public Nullable<bool> AutoZk { get; set; }
        public string Note { get; set; }
    }
}
