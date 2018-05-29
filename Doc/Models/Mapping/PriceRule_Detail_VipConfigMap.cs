using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PriceRule_Detail_VipConfigMap : EntityTypeConfiguration<PriceRule_Detail_VipConfig>
    {
        public PriceRule_Detail_VipConfigMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.StartCardNum)
                .HasMaxLength(50);

            this.Property(t => t.EndCardNum)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PriceRule_Detail_VipConfig");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PriceRuleID).HasColumnName("PriceRuleID");
            this.Property(t => t.VipTypeID).HasColumnName("VipTypeID");
            this.Property(t => t.StartCardNum).HasColumnName("StartCardNum");
            this.Property(t => t.EndCardNum).HasColumnName("EndCardNum");
        }
    }
}
