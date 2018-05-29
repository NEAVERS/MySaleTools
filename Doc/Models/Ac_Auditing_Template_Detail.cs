using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_Auditing_Template_Detail
    {
        public int AtdId { get; set; }
        public Nullable<int> Atid { get; set; }
        public string Summary { get; set; }
        public string AcFrom { get; set; }
        public string ATypeId { get; set; }
        public Nullable<int> Fdc { get; set; }
        public string BillMoneyId { get; set; }
        public string Express { get; set; }
        public string AssistCheckItmes { get; set; }
        public string AssistCheckItmesIds { get; set; }
        public string SummaryType { get; set; }
        public Nullable<int> FromAtdId { get; set; }
    }
}
