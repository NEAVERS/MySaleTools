using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Qp_SuccorChargeItemsMap : EntityTypeConfiguration<Qp_SuccorChargeItems>
    {
        public Qp_SuccorChargeItemsMap()
        {
            // Primary Key
            this.HasKey(t => t.SuccorChargeId);

            // Properties
            this.Property(t => t.FullName)
                .HasMaxLength(200);

            this.Property(t => t.PYCode)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Qp_SuccorChargeItems");
            this.Property(t => t.SuccorChargeId).HasColumnName("SuccorChargeId");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.PYCode).HasColumnName("PYCode");
        }
    }
}
