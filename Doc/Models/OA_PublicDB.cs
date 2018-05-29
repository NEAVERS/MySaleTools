using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OA_PublicDB
    {
        public int ID { get; set; }
        public string CatalogID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ETypeID_CreatorTypeID { get; set; }
        public string ETypeID_ModifierTypeID { get; set; }
        public Nullable<int> ClickNumber { get; set; }
        public Nullable<int> ReplyNumber { get; set; }
        public string EmotionImg { get; set; }
        public int HtmlCode { get; set; }
        public string ParentID { get; set; }
        public int Docking { get; set; }
        public int Hidden { get; set; }
        public int Emulate { get; set; }
        public int SortOrder { get; set; }
        public int IsEnableCreatorDel { get; set; }
        public string DocFileName { get; set; }
        public int DocFileLength { get; set; }
        public int IsRefuseRepeat { get; set; }
        public int IsVote { get; set; }
        public string VoteName { get; set; }
        public int VoteMode { get; set; }
        public Nullable<System.DateTime> VoteEndDateTime { get; set; }
        public int IsEnableVote { get; set; }
        public int IsEnableView { get; set; }
        public int IsEnableAgentVote { get; set; }
        public string Vote_S1 { get; set; }
        public string Vote_S2 { get; set; }
        public string Vote_S3 { get; set; }
        public string Vote_S4 { get; set; }
        public string Vote_S5 { get; set; }
        public string Vote_S6 { get; set; }
        public string Vote_S7 { get; set; }
        public string Vote_S8 { get; set; }
        public string Vote_S9 { get; set; }
        public string Vote_S10 { get; set; }
        public int Vote_N1 { get; set; }
        public int Vote_N2 { get; set; }
        public int Vote_N3 { get; set; }
        public int Vote_N4 { get; set; }
        public int Vote_N5 { get; set; }
        public int Vote_N6 { get; set; }
        public int Vote_N7 { get; set; }
        public int Vote_N8 { get; set; }
        public int Vote_N9 { get; set; }
        public int Vote_N10 { get; set; }
        public string IsFromDD { get; set; }
    }
}
