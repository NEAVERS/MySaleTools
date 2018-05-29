using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Te_Bank
    {
        public int Id { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PhoneNum { get; set; }
        public string ContactMan { get; set; }
        public string Comment { get; set; }
        public Nullable<int> IsSys { get; set; }
    }
}
