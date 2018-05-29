using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_Provision_Voucher
    {
        public int Id { get; set; }
        public Nullable<int> SourceId { get; set; }
        public Nullable<int> SourceType { get; set; }
        public Nullable<int> VoucherId { get; set; }
    }
}
