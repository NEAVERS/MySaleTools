using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_AssetsModifyRecords
    {
        public int Id { get; set; }
        public Nullable<int> CardId { get; set; }
        public string OldDTypeId { get; set; }
        public string DTypeId { get; set; }
        public Nullable<int> OldLocationId { get; set; }
        public Nullable<int> LocationId { get; set; }
        public string OldDisATypeId { get; set; }
        public string DisATypeId { get; set; }
        public Nullable<System.DateTime> BusinessDate { get; set; }
        public Nullable<System.DateTime> OperationDate { get; set; }
        public string ETypeId { get; set; }
    }
}
