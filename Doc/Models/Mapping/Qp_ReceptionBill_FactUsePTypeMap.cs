using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Qp_ReceptionBill_FactUsePTypeMap : EntityTypeConfiguration<Qp_ReceptionBill_FactUsePType>
    {
        public Qp_ReceptionBill_FactUsePTypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.ReceptionBillPTypeId, t.ID, t.PickingId });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ReceptionBillPTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.PickingId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PTypeID)
                .HasMaxLength(50);

            this.Property(t => t.ETypeID)
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Qp_ReceptionBill_FactUsePType");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.ReceptionBillPTypeId).HasColumnName("ReceptionBillPTypeId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PickingId).HasColumnName("PickingId");
            this.Property(t => t.PTypeID).HasColumnName("PTypeID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.CostTotal).HasColumnName("CostTotal");
            this.Property(t => t.Insurance).HasColumnName("Insurance");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
            this.Property(t => t.ReceptionBillnumberId).HasColumnName("ReceptionBillnumberId");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.DiscountPrice).HasColumnName("DiscountPrice");
            this.Property(t => t.DiscountTotal).HasColumnName("DiscountTotal");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Virtual).HasColumnName("Virtual");
            this.Property(t => t.CounterClaimStatus).HasColumnName("CounterClaimStatus");
        }
    }
}
