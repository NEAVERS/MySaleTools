using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CommissionRuleMap : EntityTypeConfiguration<CommissionRule>
    {
        public CommissionRuleMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.BillCode, t.FullName, t.BillDate, t.RuleStart, t.RuleEnd, t.CommissionStandard, t.IsUseEtypeCommission, t.ECommissionType, t.CommissionStyle, t.Checke, t.Checker, t.CheckeTime, t.Comment, t.BillState, t.UseState, t.IsStop });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.BillCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.CommissionStandard)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsUseEtypeCommission)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ECommissionType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CommissionStyle)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Checke)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Checker)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.BillState)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UseState)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsStop)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("CommissionRule");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.RuleStart).HasColumnName("RuleStart");
            this.Property(t => t.RuleEnd).HasColumnName("RuleEnd");
            this.Property(t => t.CommissionStandard).HasColumnName("CommissionStandard");
            this.Property(t => t.IsUseEtypeCommission).HasColumnName("IsUseEtypeCommission");
            this.Property(t => t.ECommissionType).HasColumnName("ECommissionType");
            this.Property(t => t.CommissionStyle).HasColumnName("CommissionStyle");
            this.Property(t => t.Checke).HasColumnName("Checke");
            this.Property(t => t.Checker).HasColumnName("Checker");
            this.Property(t => t.CheckeTime).HasColumnName("CheckeTime");
            this.Property(t => t.CheckerTime).HasColumnName("CheckerTime");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.BillState).HasColumnName("BillState");
            this.Property(t => t.UseState).HasColumnName("UseState");
            this.Property(t => t.IsStop).HasColumnName("IsStop");
        }
    }
}
