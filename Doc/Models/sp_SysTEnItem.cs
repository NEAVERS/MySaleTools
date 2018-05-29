using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class sp_SysTEnItem
    {
        public int ID { get; set; }
        public Nullable<int> sp_Id { get; set; }
        public Nullable<int> sp_SysTableName_Id { get; set; }
        public string En_Item { get; set; }
        public string Align { get; set; }
        public Nullable<int> Format { get; set; }
        public Nullable<int> Format_Num { get; set; }
        public Nullable<int> is_Sum { get; set; }
        public Nullable<int> OrderId { get; set; }
        public Nullable<int> is_Hidden { get; set; }
    }
}
