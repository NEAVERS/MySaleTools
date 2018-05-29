using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PriceRulePriorityMap : EntityTypeConfiguration<PriceRulePriority>
    {
        public PriceRulePriorityMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.StypeID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PriceRulePriority");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PriceRuleID).HasColumnName("PriceRuleID");
            this.Property(t => t.StypeID).HasColumnName("StypeID");
            this.Property(t => t.SortID).HasColumnName("SortID");
        }
    }
}
