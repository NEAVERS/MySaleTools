using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CarriageUnitMap : EntityTypeConfiguration<CarriageUnit>
    {
        public CarriageUnitMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.usercode, t.fullname });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.usercode)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.fullname)
                .IsRequired()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("CarriageUnit");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.usercode).HasColumnName("usercode");
            this.Property(t => t.fullname).HasColumnName("fullname");
        }
    }
}
