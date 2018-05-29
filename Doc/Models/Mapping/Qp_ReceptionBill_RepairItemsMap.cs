using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Qp_ReceptionBill_RepairItemsMap : EntityTypeConfiguration<Qp_ReceptionBill_RepairItems>
    {
        public Qp_ReceptionBill_RepairItemsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.ID });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.RepairItemsTypeID)
                .HasMaxLength(50);

            this.Property(t => t.StopReason)
                .HasMaxLength(250);

            this.Property(t => t.RepairMan)
                .HasMaxLength(100);

            this.Property(t => t.Comment)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Qp_ReceptionBill_RepairItems");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RepairItemsTypeID).HasColumnName("RepairItemsTypeID");
            this.Property(t => t.StandardManHour).HasColumnName("StandardManHour");
            this.Property(t => t.CheckHour).HasColumnName("CheckHour");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.CostTotal).HasColumnName("CostTotal");
            this.Property(t => t.RepairProcess).HasColumnName("RepairProcess");
            this.Property(t => t.StopReason).HasColumnName("StopReason");
            this.Property(t => t.RepairMan).HasColumnName("RepairMan");
            this.Property(t => t.StopTime).HasColumnName("StopTime");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.DiscountTotal).HasColumnName("DiscountTotal");
            this.Property(t => t.Insurance).HasColumnName("Insurance");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Virtual).HasColumnName("Virtual");
            this.Property(t => t.AppointTime).HasColumnName("AppointTime");
            this.Property(t => t.Limited).HasColumnName("Limited");
            this.Property(t => t.CounterClaimStatus).HasColumnName("CounterClaimStatus");
        }
    }
}
