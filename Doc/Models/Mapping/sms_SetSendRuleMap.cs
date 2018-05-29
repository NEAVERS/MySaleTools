using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class sms_SetSendRuleMap : EntityTypeConfiguration<sms_SetSendRule>
    {
        public sms_SetSendRuleMap()
        {
            // Primary Key
            this.HasKey(t => t.RuleID);

            // Properties
            this.Property(t => t.RuleName)
                .HasMaxLength(50);

            this.Property(t => t.QryParam)
                .HasMaxLength(100);

            this.Property(t => t.BeginDate)
                .HasMaxLength(50);

            this.Property(t => t.EndDate)
                .HasMaxLength(50);

            this.Property(t => t.Weeks)
                .HasMaxLength(50);

            this.Property(t => t.SendTime)
                .HasMaxLength(50);

            this.Property(t => t.CurrSend)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("sms_SetSendRule");
            this.Property(t => t.RuleID).HasColumnName("RuleID");
            this.Property(t => t.RuleName).HasColumnName("RuleName");
            this.Property(t => t.CodeID).HasColumnName("CodeID");
            this.Property(t => t.Phones).HasColumnName("Phones");
            this.Property(t => t.QryParam).HasColumnName("QryParam");
            this.Property(t => t.BeginDate).HasColumnName("BeginDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.TimeMode).HasColumnName("TimeMode");
            this.Property(t => t.Interval).HasColumnName("Interval");
            this.Property(t => t.Weeks).HasColumnName("Weeks");
            this.Property(t => t.SendCount).HasColumnName("SendCount");
            this.Property(t => t.SendTime).HasColumnName("SendTime");
            this.Property(t => t.CurrSend).HasColumnName("CurrSend");
        }
    }
}
