using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OftenExplainMap : EntityTypeConfiguration<OftenExplain>
    {
        public OftenExplainMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.UserCode, t.Content });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.UserCode)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Content)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("OftenExplain");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.Content).HasColumnName("Content");
        }
    }
}
