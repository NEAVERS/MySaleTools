using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PosSaleMergeFailed
    {
        public int Id { get; set; }
        public int PosBillNumberId { get; set; }
        public string Reason { get; set; }
        public string Comment { get; set; }
    }
}
