using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OA_PublicDBMap : EntityTypeConfiguration<OA_PublicDB>
    {
        public OA_PublicDBMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.HtmlCode, t.ParentID, t.Docking, t.Hidden, t.Emulate, t.SortOrder, t.IsEnableCreatorDel, t.DocFileLength, t.IsRefuseRepeat, t.IsVote, t.VoteMode, t.IsEnableVote, t.IsEnableView, t.IsEnableAgentVote, t.Vote_N1, t.Vote_N2, t.Vote_N3, t.Vote_N4, t.Vote_N5, t.Vote_N6, t.Vote_N7, t.Vote_N8, t.Vote_N9, t.Vote_N10 });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CatalogID)
                .HasMaxLength(30);

            this.Property(t => t.Title)
                .HasMaxLength(100);

            this.Property(t => t.ETypeID_CreatorTypeID)
                .HasMaxLength(50);

            this.Property(t => t.ETypeID_ModifierTypeID)
                .HasMaxLength(50);

            this.Property(t => t.EmotionImg)
                .HasMaxLength(40);

            this.Property(t => t.HtmlCode)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ParentID)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Docking)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Hidden)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Emulate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SortOrder)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsEnableCreatorDel)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DocFileName)
                .HasMaxLength(200);

            this.Property(t => t.DocFileLength)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsRefuseRepeat)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsVote)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VoteName)
                .HasMaxLength(50);

            this.Property(t => t.VoteMode)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsEnableVote)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsEnableView)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsEnableAgentVote)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Vote_S1)
                .HasMaxLength(50);

            this.Property(t => t.Vote_S2)
                .HasMaxLength(50);

            this.Property(t => t.Vote_S3)
                .HasMaxLength(50);

            this.Property(t => t.Vote_S4)
                .HasMaxLength(50);

            this.Property(t => t.Vote_S5)
                .HasMaxLength(50);

            this.Property(t => t.Vote_S6)
                .HasMaxLength(50);

            this.Property(t => t.Vote_S7)
                .HasMaxLength(50);

            this.Property(t => t.Vote_S8)
                .HasMaxLength(50);

            this.Property(t => t.Vote_S9)
                .HasMaxLength(50);

            this.Property(t => t.Vote_S10)
                .HasMaxLength(50);

            this.Property(t => t.Vote_N1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Vote_N2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Vote_N3)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Vote_N4)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Vote_N5)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Vote_N6)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Vote_N7)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Vote_N8)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Vote_N9)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Vote_N10)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsFromDD)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("OA_PublicDB");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CatalogID).HasColumnName("CatalogID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.ModifyDate).HasColumnName("ModifyDate");
            this.Property(t => t.ETypeID_CreatorTypeID).HasColumnName("ETypeID_CreatorTypeID");
            this.Property(t => t.ETypeID_ModifierTypeID).HasColumnName("ETypeID_ModifierTypeID");
            this.Property(t => t.ClickNumber).HasColumnName("ClickNumber");
            this.Property(t => t.ReplyNumber).HasColumnName("ReplyNumber");
            this.Property(t => t.EmotionImg).HasColumnName("EmotionImg");
            this.Property(t => t.HtmlCode).HasColumnName("HtmlCode");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
            this.Property(t => t.Docking).HasColumnName("Docking");
            this.Property(t => t.Hidden).HasColumnName("Hidden");
            this.Property(t => t.Emulate).HasColumnName("Emulate");
            this.Property(t => t.SortOrder).HasColumnName("SortOrder");
            this.Property(t => t.IsEnableCreatorDel).HasColumnName("IsEnableCreatorDel");
            this.Property(t => t.DocFileName).HasColumnName("DocFileName");
            this.Property(t => t.DocFileLength).HasColumnName("DocFileLength");
            this.Property(t => t.IsRefuseRepeat).HasColumnName("IsRefuseRepeat");
            this.Property(t => t.IsVote).HasColumnName("IsVote");
            this.Property(t => t.VoteName).HasColumnName("VoteName");
            this.Property(t => t.VoteMode).HasColumnName("VoteMode");
            this.Property(t => t.VoteEndDateTime).HasColumnName("VoteEndDateTime");
            this.Property(t => t.IsEnableVote).HasColumnName("IsEnableVote");
            this.Property(t => t.IsEnableView).HasColumnName("IsEnableView");
            this.Property(t => t.IsEnableAgentVote).HasColumnName("IsEnableAgentVote");
            this.Property(t => t.Vote_S1).HasColumnName("Vote_S1");
            this.Property(t => t.Vote_S2).HasColumnName("Vote_S2");
            this.Property(t => t.Vote_S3).HasColumnName("Vote_S3");
            this.Property(t => t.Vote_S4).HasColumnName("Vote_S4");
            this.Property(t => t.Vote_S5).HasColumnName("Vote_S5");
            this.Property(t => t.Vote_S6).HasColumnName("Vote_S6");
            this.Property(t => t.Vote_S7).HasColumnName("Vote_S7");
            this.Property(t => t.Vote_S8).HasColumnName("Vote_S8");
            this.Property(t => t.Vote_S9).HasColumnName("Vote_S9");
            this.Property(t => t.Vote_S10).HasColumnName("Vote_S10");
            this.Property(t => t.Vote_N1).HasColumnName("Vote_N1");
            this.Property(t => t.Vote_N2).HasColumnName("Vote_N2");
            this.Property(t => t.Vote_N3).HasColumnName("Vote_N3");
            this.Property(t => t.Vote_N4).HasColumnName("Vote_N4");
            this.Property(t => t.Vote_N5).HasColumnName("Vote_N5");
            this.Property(t => t.Vote_N6).HasColumnName("Vote_N6");
            this.Property(t => t.Vote_N7).HasColumnName("Vote_N7");
            this.Property(t => t.Vote_N8).HasColumnName("Vote_N8");
            this.Property(t => t.Vote_N9).HasColumnName("Vote_N9");
            this.Property(t => t.Vote_N10).HasColumnName("Vote_N10");
            this.Property(t => t.IsFromDD).HasColumnName("IsFromDD");
        }
    }
}
