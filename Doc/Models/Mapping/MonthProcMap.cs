using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class MonthProcMap : EntityTypeConfiguration<MonthProc>
    {
        public MonthProcMap()
        {
            // Primary Key
            this.HasKey(t => t.MonthNo);

            // Properties
            this.Property(t => t.MonthNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.comment)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MonthProc");
            this.Property(t => t.MonthNo).HasColumnName("MonthNo");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.period).HasColumnName("period");
            this.Property(t => t.comment).HasColumnName("comment");
        }
    }
}
