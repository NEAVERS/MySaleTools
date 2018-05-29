using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PriceRule_Detail_BConfigMap : EntityTypeConfiguration<PriceRule_Detail_BConfig>
    {
        public PriceRule_Detail_BConfigMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Btypeid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PriceRule_Detail_BConfig");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PriceRuleID).HasColumnName("PriceRuleID");
            this.Property(t => t.Btypeid).HasColumnName("Btypeid");
        }
    }
}
