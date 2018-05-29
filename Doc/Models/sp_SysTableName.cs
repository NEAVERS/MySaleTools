using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class sp_SysTableName
    {
        public int ID { get; set; }
        public Nullable<int> sp_Id { get; set; }
        public string sp_TableName { get; set; }
        public Nullable<int> OrderId { get; set; }
    }
}
