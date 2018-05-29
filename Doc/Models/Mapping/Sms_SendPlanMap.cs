using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Sms_SendPlanMap : EntityTypeConfiguration<Sms_SendPlan>
    {
        public Sms_SendPlanMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PlanID, t.QryCode, t.QryParam, t.SendTime, t.RuleID, t.State });

            // Properties
            this.Property(t => t.PlanID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.QryCode)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.QryParam)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.SendTime)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.RuleID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.State)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Sms_SendPlan");
            this.Property(t => t.PlanID).HasColumnName("PlanID");
            this.Property(t => t.Phones).HasColumnName("Phones");
            this.Property(t => t.QryCode).HasColumnName("QryCode");
            this.Property(t => t.QryParam).HasColumnName("QryParam");
            this.Property(t => t.SendTime).HasColumnName("SendTime");
            this.Property(t => t.RuleID).HasColumnName("RuleID");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
