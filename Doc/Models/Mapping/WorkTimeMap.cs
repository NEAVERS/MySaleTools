using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class WorkTimeMap : EntityTypeConfiguration<WorkTime>
    {
        public WorkTimeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.STypeID, t.StartTime, t.EndTime, t.LateTime, t.WorkDay });

            // Properties
            this.Property(t => t.STypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LateTime)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.WorkDay)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("WorkTime");
            this.Property(t => t.STypeID).HasColumnName("STypeID");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.LateTime).HasColumnName("LateTime");
            this.Property(t => t.WorkDay).HasColumnName("WorkDay");
        }
    }
}
