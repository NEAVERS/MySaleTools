using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PosBranchView
    {
        public string BranchID { get; set; }
        public string ParID { get; set; }
        public int Sonnum { get; set; }
        public short Leveal { get; set; }
        public int Rec { get; set; }
        public int Soncount { get; set; }
        public int branchtype { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public string Namepy { get; set; }
        public string Comment { get; set; }
        public string Area { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public bool Deleted { get; set; }
        public int CheckAndAccept { get; set; }
        public string BtypeId { get; set; }
        public int DefTaxRate { get; set; }
        public string DefBtypeId { get; set; }
        public string DefKtypeId { get; set; }
        public string DefAtypeId { get; set; }
        public int CashAsBillMoney { get; set; }
        public int RoundType { get; set; }
        public int PayType { get; set; }
        public Nullable<decimal> UpdateTag { get; set; }
        public string ExtId { get; set; }
    }
}
