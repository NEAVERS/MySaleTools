using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PromoRule_Detail_VIPConfigMap : EntityTypeConfiguration<PromoRule_Detail_VIPConfig>
    {
        public PromoRule_Detail_VIPConfigMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.PromoRuleID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.PromoRuleID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.StartCardNum)
                .HasMaxLength(20);

            this.Property(t => t.EndCardNum)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("PromoRule_Detail_VIPConfig");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PromoRuleID).HasColumnName("PromoRuleID");
            this.Property(t => t.VipTypeID).HasColumnName("VipTypeID");
            this.Property(t => t.StartCardNum).HasColumnName("StartCardNum");
            this.Property(t => t.EndCardNum).HasColumnName("EndCardNum");
        }
    }
}
