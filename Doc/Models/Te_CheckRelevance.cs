using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Te_CheckRelevance
    {
        public int Id { get; set; }
        public Nullable<int> JournalId { get; set; }
        public Nullable<int> StatementId { get; set; }
        public Nullable<System.DateTime> RelevanceDate { get; set; }
        public Nullable<int> GroupId { get; set; }
        public Nullable<int> StatementAccountInTransitId { get; set; }
        public Nullable<int> JournalAccountInTransitId { get; set; }
    }
}
