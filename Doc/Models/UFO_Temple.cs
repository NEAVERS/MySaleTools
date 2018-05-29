using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class UFO_Temple
    {
        public int ID { get; set; }
        public string TempleName { get; set; }
        public Nullable<int> ModeID { get; set; }
        public string CreateEtypeID { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string UpdateEtypeID { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public string TempleContent { get; set; }
        public int IsVisible { get; set; }
        public string TempleCategoryID { get; set; }
        public string CreateEtypeName { get; set; }
        public string UpdateEtypeName { get; set; }
        public Nullable<int> ClassId { get; set; }
        public string Stypeid { get; set; }
        public string Fyear { get; set; }
        public Nullable<int> Fperiod { get; set; }
        public Nullable<int> ShownotPost { get; set; }
        public Nullable<int> IsShare { get; set; }
        public string ReMarks { get; set; }
        public string TStypeid { get; set; }
        public Nullable<System.DateTime> BeginDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
    }
}
