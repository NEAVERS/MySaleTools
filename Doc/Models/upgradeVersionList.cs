using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class upgradeVersionList
    {
        public int UpgradeId { get; set; }
        public string oldVersion { get; set; }
        public string oldMidVersion { get; set; }
        public string newVersion { get; set; }
        public string newMidVersion { get; set; }
        public Nullable<System.DateTime> UpgradeDate { get; set; }
    }
}
