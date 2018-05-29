using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class QP_InsuranceBill_RepairItemsMap : EntityTypeConfiguration<QP_InsuranceBill_RepairItems>
    {
        public QP_InsuranceBill_RepairItemsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.ID, t.RepairItemsTypeID, t.Virtual });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.RepairItemsTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Virtual)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment)
                .HasMaxLength(500);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("QP_InsuranceBill_RepairItems");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RepairItemsTypeID).HasColumnName("RepairItemsTypeID");
            this.Property(t => t.ManHour).HasColumnName("ManHour");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.InsuranceTotal).HasColumnName("InsuranceTotal");
            this.Property(t => t.CostTotal).HasColumnName("CostTotal");
            this.Property(t => t.Virtual).HasColumnName("Virtual");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.QuickOrReceptionBillId).HasColumnName("QuickOrReceptionBillId");
        }
    }
}
