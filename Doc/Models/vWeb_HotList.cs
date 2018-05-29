using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class vWeb_HotList
    {
        public Nullable<System.DateTime> HappenDate { get; set; }
        public string Title { get; set; }
        public string PloyName { get; set; }
        public string BFullName { get; set; }
        public string EFullName { get; set; }
        public string Etypeid { get; set; }
        public string Btypeid { get; set; }
        public Nullable<int> PloyTypeid { get; set; }
        public Nullable<int> New_number { get; set; }
        public int ID { get; set; }
        public string Address { get; set; }
        public string Comment { get; set; }
    }
}
