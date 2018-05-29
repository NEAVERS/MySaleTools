using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Sms_AlarmSendRuleMap : EntityTypeConfiguration<Sms_AlarmSendRule>
    {
        public Sms_AlarmSendRuleMap()
        {
            // Primary Key
            this.HasKey(t => t.RuleID);

            // Properties
            this.Property(t => t.RuleName)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("Sms_AlarmSendRule");
            this.Property(t => t.RuleID).HasColumnName("RuleID");
            this.Property(t => t.VchType).HasColumnName("VchType");
            this.Property(t => t.RuleName).HasColumnName("RuleName");
            this.Property(t => t.Phones).HasColumnName("Phones");
            this.Property(t => t.AlarmNum).HasColumnName("AlarmNum");
            this.Property(t => t.AlarmType).HasColumnName("AlarmType");
            this.Property(t => t.SendCount).HasColumnName("SendCount");
        }
    }
}
