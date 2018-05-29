using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class news
    {
        public int ID { get; set; }
        public Nullable<int> nCatalogID { get; set; }
        public string strTitle { get; set; }
        public string strContent { get; set; }
        public string strDateTime { get; set; }
        public string strAuthor { get; set; }
        public int nClickNumber { get; set; }
        public string nAuthorID { get; set; }
        public bool IsDocking { get; set; }
    }
}
