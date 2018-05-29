using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class SchemeMap : EntityTypeConfiguration<Scheme>
    {
        public SchemeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SchemeId, t.ETypeID });

            // Properties
            this.Property(t => t.SchemeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ETypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ReportName)
                .HasMaxLength(500);

            this.Property(t => t.SchemeName)
                .HasMaxLength(500);

            this.Property(t => t.inputtype)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Scheme");
            this.Property(t => t.SchemeId).HasColumnName("SchemeId");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
            this.Property(t => t.ReportName).HasColumnName("ReportName");
            this.Property(t => t.SchemeName).HasColumnName("SchemeName");
            this.Property(t => t.IsDefault).HasColumnName("IsDefault");
            this.Property(t => t.inputtype).HasColumnName("inputtype");
        }
    }
}
