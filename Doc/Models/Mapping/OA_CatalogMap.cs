using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OA_CatalogMap : EntityTypeConfiguration<OA_Catalog>
    {
        public OA_CatalogMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.FontColor, t.ImgFileName, t.Expand, t.IsFlowCheck, t.IsCascadeCheck, t.ClickNumber, t.SplitBanner });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.TypeID)
                .HasMaxLength(50);

            this.Property(t => t.ParentID)
                .HasMaxLength(30);

            this.Property(t => t.Name)
                .HasMaxLength(40);

            this.Property(t => t.Description)
                .HasMaxLength(400);

            this.Property(t => t.FontColor)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ImgFileName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Expand)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsFlowCheck)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsCascadeCheck)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ClickNumber)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SplitBanner)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SplitImg)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OA_Catalog");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
            this.Property(t => t.SonNumber).HasColumnName("SonNumber");
            this.Property(t => t.SonCounter).HasColumnName("SonCounter");
            this.Property(t => t.SortOrder).HasColumnName("SortOrder");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.FontColor).HasColumnName("FontColor");
            this.Property(t => t.ImgFileName).HasColumnName("ImgFileName");
            this.Property(t => t.Expand).HasColumnName("Expand");
            this.Property(t => t.IsFlowCheck).HasColumnName("IsFlowCheck");
            this.Property(t => t.IsCascadeCheck).HasColumnName("IsCascadeCheck");
            this.Property(t => t.ClickNumber).HasColumnName("ClickNumber");
            this.Property(t => t.SplitBanner).HasColumnName("SplitBanner");
            this.Property(t => t.SplitImg).HasColumnName("SplitImg");
        }
    }
}
