using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class BarCodeMap : EntityTypeConfiguration<BarCode>
    {
        public BarCodeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.UserCode, t.FullName, t.Deleted, t.IsDefault, t.IsPrint });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.UserCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("BarCode");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
            this.Property(t => t.IsDefault).HasColumnName("IsDefault");
            this.Property(t => t.IsPrint).HasColumnName("IsPrint");
        }
    }
}
