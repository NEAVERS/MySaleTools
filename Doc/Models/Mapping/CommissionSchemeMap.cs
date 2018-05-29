using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CommissionSchemeMap : EntityTypeConfiguration<CommissionScheme>
    {
        public CommissionSchemeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.SchemeName, t.CommissionRuleID, t.ReferencePlanID, t.Comment, t.Checke, t.Checker, t.CheckeTime, t.BillState, t.UseState, t.IsStop });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.SchemeName)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.CommissionRuleID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ReferencePlanID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Checke)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Checker)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BillState)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UseState)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsStop)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("CommissionScheme");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.SchemeStart).HasColumnName("SchemeStart");
            this.Property(t => t.SchemeEnd).HasColumnName("SchemeEnd");
            this.Property(t => t.SchemeName).HasColumnName("SchemeName");
            this.Property(t => t.CommissionRuleID).HasColumnName("CommissionRuleID");
            this.Property(t => t.ReferencePlanID).HasColumnName("ReferencePlanID");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Checke).HasColumnName("Checke");
            this.Property(t => t.Checker).HasColumnName("Checker");
            this.Property(t => t.CheckeTime).HasColumnName("CheckeTime");
            this.Property(t => t.CheckerTime).HasColumnName("CheckerTime");
            this.Property(t => t.BillState).HasColumnName("BillState");
            this.Property(t => t.UseState).HasColumnName("UseState");
            this.Property(t => t.IsStop).HasColumnName("IsStop");
        }
    }
}
