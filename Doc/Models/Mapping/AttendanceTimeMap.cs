using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class AttendanceTimeMap : EntityTypeConfiguration<AttendanceTime>
    {
        public AttendanceTimeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.date, t.StartTime, t.EndTime, t.LeaveReasonID, t.Comment, t.Islate });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.etypeid)
                .HasMaxLength(50);

            this.Property(t => t.LeaveReasonID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Islate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AttendanceTime");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.LeaveReasonID).HasColumnName("LeaveReasonID");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Islate).HasColumnName("Islate");
        }
    }
}
