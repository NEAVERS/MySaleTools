using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class AdDebtBillMap : EntityTypeConfiguration<AdDebtBill>
    {
        public AdDebtBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.ID, t.AlertDay, t.IfStopMoney, t.ChargeOffTotal });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            this.Property(t => t.BtypeId)
                .HasMaxLength(50);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            this.Property(t => t.AlertDay)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ChargeOffTotal)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AdDebtBill");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.BtypeId).HasColumnName("BtypeId");
            this.Property(t => t.total).HasColumnName("total");
            this.Property(t => t.TeamNo).HasColumnName("TeamNo");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TeamNO1).HasColumnName("TeamNO1");
            this.Property(t => t.CompleteTotal).HasColumnName("CompleteTotal");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.NTotal).HasColumnName("NTotal");
            this.Property(t => t.NCompleteTotal).HasColumnName("NCompleteTotal");
            this.Property(t => t.ShowOrder).HasColumnName("ShowOrder");
            this.Property(t => t.AlertDay).HasColumnName("AlertDay");
            this.Property(t => t.IfStopMoney).HasColumnName("IfStopMoney");
            this.Property(t => t.ChargeOffTotal).HasColumnName("ChargeOffTotal");
            this.Property(t => t.NChargeOffTotal).HasColumnName("NChargeOffTotal");
        }
    }
}
