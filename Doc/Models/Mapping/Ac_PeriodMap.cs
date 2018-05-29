using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_PeriodMap : EntityTypeConfiguration<Ac_Period>
    {
        public Ac_PeriodMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PeriodId, t.FYear, t.FMonth, t.IsCurrent, t.IsDynamic });

            // Properties
            this.Property(t => t.PeriodId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.FYear)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.FMonth)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.IsCurrent)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsDynamic)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Ac_Period");
            this.Property(t => t.PeriodId).HasColumnName("PeriodId");
            this.Property(t => t.FYear).HasColumnName("FYear");
            this.Property(t => t.FMonth).HasColumnName("FMonth");
            this.Property(t => t.IsNature).HasColumnName("IsNature");
            this.Property(t => t.NatureCount).HasColumnName("NatureCount");
            this.Property(t => t.FPeriod).HasColumnName("FPeriod");
            this.Property(t => t.FBegin).HasColumnName("FBegin");
            this.Property(t => t.FEnd).HasColumnName("FEnd");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
            this.Property(t => t.IsCurrent).HasColumnName("IsCurrent");
            this.Property(t => t.IsDynamic).HasColumnName("IsDynamic");
        }
    }
}
