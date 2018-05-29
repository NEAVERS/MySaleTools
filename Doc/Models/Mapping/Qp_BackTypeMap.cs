using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Qp_BackTypeMap : EntityTypeConfiguration<Qp_BackType>
    {
        public Qp_BackTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.BackTypeId);

            // Properties
            this.Property(t => t.FullName)
                .HasMaxLength(200);

            this.Property(t => t.PYCode)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Qp_BackType");
            this.Property(t => t.BackTypeId).HasColumnName("BackTypeId");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.PYCode).HasColumnName("PYCode");
        }
    }
}
