using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Te_StartPeriodMap : EntityTypeConfiguration<Te_StartPeriod>
    {
        public Te_StartPeriodMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.STypeId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Te_StartPeriod");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.STypeId).HasColumnName("STypeId");
            this.Property(t => t.SFYear).HasColumnName("SFYear");
            this.Property(t => t.SFPeriod).HasColumnName("SFPeriod");
            this.Property(t => t.IsConnect).HasColumnName("IsConnect");
            this.Property(t => t.CFYear).HasColumnName("CFYear");
            this.Property(t => t.CFPeriod).HasColumnName("CFPeriod");
            this.Property(t => t.IsUse).HasColumnName("IsUse");
        }
    }
}
