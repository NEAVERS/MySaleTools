using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Qp_PickingBillMap : EntityTypeConfiguration<Qp_PickingBill>
    {
        public Qp_PickingBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.ID, t.ReceptionBillId });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ReceptionBillId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.KTypeID)
                .HasMaxLength(50);

            this.Property(t => t.CargoSpace)
                .HasMaxLength(200);

            this.Property(t => t.PTypeID)
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Qp_PickingBill");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ReceptionBillId).HasColumnName("ReceptionBillId");
            this.Property(t => t.KTypeID).HasColumnName("KTypeID");
            this.Property(t => t.CargoSpace).HasColumnName("CargoSpace");
            this.Property(t => t.PTypeID).HasColumnName("PTypeID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.BackQty).HasColumnName("BackQty");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.InputCostPrice).HasColumnName("InputCostPrice");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.Insurance).HasColumnName("Insurance");
            this.Property(t => t.IsUnit2).HasColumnName("IsUnit2");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.HandZeroCost).HasColumnName("HandZeroCost");
        }
    }
}
