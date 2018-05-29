using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Qp_ThreePacketsBill_RepairItemsMap : EntityTypeConfiguration<Qp_ThreePacketsBill_RepairItems>
    {
        public Qp_ThreePacketsBill_RepairItemsMap()
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

            this.Property(t => t.Comment)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Qp_ThreePacketsBill_RepairItems");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RepairItemsTypeID).HasColumnName("RepairItemsTypeID");
            this.Property(t => t.StandardManHour).HasColumnName("StandardManHour");
            this.Property(t => t.RepairTotal).HasColumnName("RepairTotal");
            this.Property(t => t.InsuranceTotal).HasColumnName("InsuranceTotal");
            this.Property(t => t.CostTotal).HasColumnName("CostTotal");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.QuickOrReceptionBillId).HasColumnName("QuickOrReceptionBillId");
            this.Property(t => t.Virtual).HasColumnName("Virtual");
        }
    }
}
