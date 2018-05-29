using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Te_BankAccount
    {
        public int Id { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public string AccountNumber { get; set; }
        public string STypeId { get; set; }
        public Nullable<int> BankId { get; set; }
        public string ATypeId { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> IsDestroy { get; set; }
        public Nullable<System.DateTime> DestroyDate { get; set; }
        public string DestroyReson { get; set; }
        public string Comment { get; set; }
        public Nullable<int> Cid { get; set; }
        public Nullable<decimal> XiWaMaxNumber { get; set; }
        public Nullable<int> YearClose { get; set; }
    }
}
