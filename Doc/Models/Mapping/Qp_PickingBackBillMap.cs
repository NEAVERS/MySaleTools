using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Qp_PickingBackBillMap : EntityTypeConfiguration<Qp_PickingBackBill>
    {
        public Qp_PickingBackBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.ID });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.KTypeId)
                .HasMaxLength(50);

            this.Property(t => t.PTypeId)
                .HasMaxLength(50);

            this.Property(t => t.CargoSpace)
                .HasMaxLength(200);

            this.Property(t => t.Comment)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Qp_PickingBackBill");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PickingId).HasColumnName("PickingId");
            this.Property(t => t.KTypeId).HasColumnName("KTypeId");
            this.Property(t => t.PTypeId).HasColumnName("PTypeId");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.InputCostPrice).HasColumnName("InputCostPrice");
            this.Property(t => t.CargoSpace).HasColumnName("CargoSpace");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.Insurance).HasColumnName("Insurance");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.IsUnit2).HasColumnName("IsUnit2");
            this.Property(t => t.HandZeroCost).HasColumnName("HandZeroCost");
        }
    }
}
