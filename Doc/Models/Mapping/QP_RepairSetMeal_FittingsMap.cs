using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class QP_RepairSetMeal_FittingsMap : EntityTypeConfiguration<QP_RepairSetMeal_Fittings>
    {
        public QP_RepairSetMeal_FittingsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.TypeID, t.PTypeID });

            // Properties
            this.Property(t => t.TypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PTypeID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("QP_RepairSetMeal_Fittings");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.PTypeID).HasColumnName("PTypeID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Total).HasColumnName("Total");
        }
    }
}
