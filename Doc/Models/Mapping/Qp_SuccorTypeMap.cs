using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Qp_SuccorTypeMap : EntityTypeConfiguration<Qp_SuccorType>
    {
        public Qp_SuccorTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.SuccorId);

            // Properties
            this.Property(t => t.FullName)
                .HasMaxLength(200);

            this.Property(t => t.PYCode)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Qp_SuccorType");
            this.Property(t => t.SuccorId).HasColumnName("SuccorId");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.PYCode).HasColumnName("PYCode");
        }
    }
}
