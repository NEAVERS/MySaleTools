using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OM_QuestionReply
    {
        public int Id { get; set; }
        public string Contents { get; set; }
        public string Reply { get; set; }
        public int CreatorId { get; set; }
        public string CreatorName { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public int ModifierId { get; set; }
        public string ModifierName { get; set; }
        public System.DateTime ModifiedTime { get; set; }
    }
}
