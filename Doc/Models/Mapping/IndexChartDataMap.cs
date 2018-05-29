using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class IndexChartDataMap : EntityTypeConfiguration<IndexChartData>
    {
        public IndexChartDataMap()
        {
            // Primary Key
            this.HasKey(t => t.TypeID);

            // Properties
            this.Property(t => t.TypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FullName)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("IndexChartData");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.total).HasColumnName("total");
            this.Property(t => t.Total1).HasColumnName("Total1");
            this.Property(t => t.Total2).HasColumnName("Total2");
            this.Property(t => t.flag).HasColumnName("flag");
            this.Property(t => t.CountType).HasColumnName("CountType");
        }
    }
}
