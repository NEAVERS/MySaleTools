using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Qp_ReceptionBill_Pic
    {
        public decimal BillNumberId { get; set; }
        public int ID { get; set; }
        public byte[] Pic { get; set; }
        public string ImgPoint { get; set; }
    }
}
