using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class QP_RepairSetMeal_ItemsMap : EntityTypeConfiguration<QP_RepairSetMeal_Items>
    {
        public QP_RepairSetMeal_ItemsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RepairItemsTypeID, t.TypeID });

            // Properties
            this.Property(t => t.RepairItemsTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TypeID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("QP_RepairSetMeal_Items");
            this.Property(t => t.RepairItemsTypeID).HasColumnName("RepairItemsTypeID");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.StandardManHour).HasColumnName("StandardManHour");
            this.Property(t => t.CheckManHour).HasColumnName("CheckManHour");
            this.Property(t => t.ManHourExpense).HasColumnName("ManHourExpense");
        }
    }
}
