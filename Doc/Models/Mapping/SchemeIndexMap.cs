using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class SchemeIndexMap : EntityTypeConfiguration<SchemeIndex>
    {
        public SchemeIndexMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.SchemeName, t.SchemeExplain, t.IsDefault, t.RuleType, t.CreateTime, t.CreateID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.SchemeName)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.SchemeExplain)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.IsDefault)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RuleType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CreateID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SchemeIndex");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SchemeName).HasColumnName("SchemeName");
            this.Property(t => t.SchemeExplain).HasColumnName("SchemeExplain");
            this.Property(t => t.IsDefault).HasColumnName("IsDefault");
            this.Property(t => t.RuleType).HasColumnName("RuleType");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.CreateID).HasColumnName("CreateID");
        }
    }
}
