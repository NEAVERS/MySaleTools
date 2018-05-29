using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OA_RightTemplateDetailMap : EntityTypeConfiguration<OA_RightTemplateDetail>
    {
        public OA_RightTemplateDetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.TemplateID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.TemplateID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CatalogTypeID)
                .HasMaxLength(30);

            this.Property(t => t.RightString)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("OA_RightTemplateDetail");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TemplateID).HasColumnName("TemplateID");
            this.Property(t => t.CatalogTypeID).HasColumnName("CatalogTypeID");
            this.Property(t => t.RightString).HasColumnName("RightString");
        }
    }
}
