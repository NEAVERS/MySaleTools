using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Te_PeriodMap : EntityTypeConfiguration<Te_Period>
    {
        public Te_PeriodMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.STypeId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Te_Period");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.STypeId).HasColumnName("STypeId");
            this.Property(t => t.FYear).HasColumnName("FYear");
            this.Property(t => t.FPeriod).HasColumnName("FPeriod");
        }
    }
}
