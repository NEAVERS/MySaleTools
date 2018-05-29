using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class QP_QuickRepairBill_PTypeMap : EntityTypeConfiguration<QP_QuickRepairBill_PType>
    {
        public QP_QuickRepairBill_PTypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.ID, t.KTypeID, t.PTypeID, t.RepairManTypeID, t.IsUnit2, t.HandZeroCost, t.Insurance });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.KTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CargoSpace)
                .HasMaxLength(200);

            this.Property(t => t.PTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RepairManTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(250);

            this.Property(t => t.IsUnit2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HandZeroCost)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Insurance)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("QP_QuickRepairBill_PType");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.KTypeID).HasColumnName("KTypeID");
            this.Property(t => t.CargoSpace).HasColumnName("CargoSpace");
            this.Property(t => t.PTypeID).HasColumnName("PTypeID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.total).HasColumnName("total");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.DiscountPrice).HasColumnName("DiscountPrice");
            this.Property(t => t.DiscountTotal).HasColumnName("DiscountTotal");
            this.Property(t => t.RepairManTypeID).HasColumnName("RepairManTypeID");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.IsUnit2).HasColumnName("IsUnit2");
            this.Property(t => t.InputCostPrice).HasColumnName("InputCostPrice");
            this.Property(t => t.GoodsCostPrice).HasColumnName("GoodsCostPrice");
            this.Property(t => t.GoodsCostTotal).HasColumnName("GoodsCostTotal");
            this.Property(t => t.HandZeroCost).HasColumnName("HandZeroCost");
            this.Property(t => t.Insurance).HasColumnName("Insurance");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.CounterClaimStatus).HasColumnName("CounterClaimStatus");
        }
    }
}
