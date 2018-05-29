using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OM_PtypeClassMap : EntityTypeConfiguration<OM_PtypeClass>
    {
        public OM_PtypeClassMap()
        {
            // Primary Key
            this.HasKey(t => t.TypeID);

            // Properties
            this.Property(t => t.TypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UserCode)
                .HasMaxLength(50);

            this.Property(t => t.FullName)
                .HasMaxLength(100);

            this.Property(t => t.ParID)
                .HasMaxLength(50);

            this.Property(t => t.Remark)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("OM_PtypeClass");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.ParID).HasColumnName("ParID");
            this.Property(t => t.Leveal).HasColumnName("Leveal");
            this.Property(t => t.Sonnum).HasColumnName("Sonnum");
            this.Property(t => t.Soncount).HasColumnName("Soncount");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}
