using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class SaleTimeMap : EntityTypeConfiguration<SaleTime>
    {
        public SaleTimeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.PeriodTime)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("SaleTime");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TotalID).HasColumnName("TotalID");
            this.Property(t => t.PeriodTime).HasColumnName("PeriodTime");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.Days).HasColumnName("Days");
        }
    }
}
