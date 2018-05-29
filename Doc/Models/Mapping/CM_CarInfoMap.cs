using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CM_CarInfoMap : EntityTypeConfiguration<CM_CarInfo>
    {
        public CM_CarInfoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.TypeId, t.Platenumber, t.Cartype });

            // Properties
            this.Property(t => t.TypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Platenumber)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Cartype)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Driver)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CM_CarInfo");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
            this.Property(t => t.Platenumber).HasColumnName("Platenumber");
            this.Property(t => t.Cartype).HasColumnName("Cartype");
            this.Property(t => t.Receptiondate).HasColumnName("Receptiondate");
            this.Property(t => t.Driver).HasColumnName("Driver");
        }
    }
}
