using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CapitalTransfer_Bill
    {
        public int ID { get; set; }
        public int BillNumberId { get; set; }
        public string BankAccountOut { get; set; }
        public string BankAccountIn { get; set; }
        public Nullable<decimal> TransferPrice { get; set; }
        public Nullable<decimal> DeductPrice { get; set; }
        public Nullable<decimal> NTransferPrice { get; set; }
        public Nullable<decimal> NDeductPrice { get; set; }
        public string Comment { get; set; }
    }
}
