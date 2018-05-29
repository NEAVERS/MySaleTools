using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class crm_linkman
    {
        public int id { get; set; }
        public string createor { get; set; }
        public string createorName { get; set; }
        public Nullable<int> Crm_BtypeId { get; set; }
        public string LinkMan { get; set; }
        public bool LinkSex { get; set; }
        public Nullable<System.DateTime> LinkBirthDay { get; set; }
        public string LinkJob { get; set; }
        public string LinkCall { get; set; }
        public string LinkTel { get; set; }
        public string LinkMobile { get; set; }
        public string LinkPost { get; set; }
        public string LinkAddress { get; set; }
        public string LinkEmail { get; set; }
        public string LinkComment { get; set; }
        public int Deleted { get; set; }
        public System.DateTime CreateDate { get; set; }
    }
}
