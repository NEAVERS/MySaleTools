using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PriceRule_Detail_DConfigMap : EntityTypeConfiguration<PriceRule_Detail_DConfig>
    {
        public PriceRule_Detail_DConfigMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Dtypeid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PriceRule_Detail_DConfig");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PriceRuleID).HasColumnName("PriceRuleID");
            this.Property(t => t.Dtypeid).HasColumnName("Dtypeid");
        }
    }
}
