using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CargoTypeMap : EntityTypeConfiguration<CargoType>
    {
        public CargoTypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CargoID, t.IsDefault });

            // Properties
            this.Property(t => t.CargoID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.UserCode)
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .HasMaxLength(200);

            this.Property(t => t.KtypeID)
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(500);

            this.Property(t => t.PyCode)
                .HasMaxLength(200);

            this.Property(t => t.IsDefault)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("CargoType");
            this.Property(t => t.CargoID).HasColumnName("CargoID");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.KtypeID).HasColumnName("KtypeID");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.deleted).HasColumnName("deleted");
            this.Property(t => t.IsDefault).HasColumnName("IsDefault");
            this.Property(t => t.XiWaMaxNumber).HasColumnName("XiWaMaxNumber");
        }
    }
}
