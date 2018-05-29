using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class DepPlanIndexMap : EntityTypeConfiguration<DepPlanIndex>
    {
        public DepPlanIndexMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("DepPlanIndex");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.AssetCardId).HasColumnName("AssetCardId");
            this.Property(t => t.DepType).HasColumnName("DepType");
            this.Property(t => t.Cid).HasColumnName("Cid");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.Flag).HasColumnName("Flag");
            this.Property(t => t.DateTime).HasColumnName("DateTime");
        }
    }
}
