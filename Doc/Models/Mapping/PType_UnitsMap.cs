using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PType_UnitsMap : EntityTypeConfiguration<PType_Units>
    {
        public PType_UnitsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.UnitsId, t.UserCode, t.FullName });

            // Properties
            this.Property(t => t.UnitsId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.UserCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Comment)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("PType_Units");
            this.Property(t => t.UnitsId).HasColumnName("UnitsId");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
