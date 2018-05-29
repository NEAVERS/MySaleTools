using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class VipAddMoneyBatchBillMap : EntityTypeConfiguration<VipAddMoneyBatchBill>
    {
        public VipAddMoneyBatchBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.Id, t.VipCardId, t.Comment });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.VipCardId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("VipAddMoneyBatchBill");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.VipCardId).HasColumnName("VipCardId");
            this.Property(t => t.BeforeChargeMoney).HasColumnName("BeforeChargeMoney");
            this.Property(t => t.AfterChargeMoney).HasColumnName("AfterChargeMoney");
            this.Property(t => t.ChargeMoney).HasColumnName("ChargeMoney");
            this.Property(t => t.PreferenceMoney).HasColumnName("PreferenceMoney");
            this.Property(t => t.TotalInMoney).HasColumnName("TotalInMoney");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.ShowOrder).HasColumnName("ShowOrder");
        }
    }
}
