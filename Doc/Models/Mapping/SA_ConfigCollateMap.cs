using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class SA_ConfigCollateMap : EntityTypeConfiguration<SA_ConfigCollate>
    {
        public SA_ConfigCollateMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.reportName)
                .HasMaxLength(100);

            this.Property(t => t.orTableName)
                .HasMaxLength(100);

            this.Property(t => t.combineproName)
                .HasMaxLength(100);

            this.Property(t => t.queryProName)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("SA_ConfigCollate");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.reportName).HasColumnName("reportName");
            this.Property(t => t.orTableName).HasColumnName("orTableName");
            this.Property(t => t.combineproName).HasColumnName("combineproName");
            this.Property(t => t.queryProName).HasColumnName("queryProName");
        }
    }
}
