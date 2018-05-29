using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class ManualRegistMap : EntityTypeConfiguration<ManualRegist>
    {
        public ManualRegistMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.AttendanceTimeId, t.RegistStartTime, t.RegistEndTime, t.RegistReason });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.AttendanceTimeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RegistReason)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.etypeid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ManualRegist");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.AttendanceTimeId).HasColumnName("AttendanceTimeId");
            this.Property(t => t.RegistStartTime).HasColumnName("RegistStartTime");
            this.Property(t => t.RegistEndTime).HasColumnName("RegistEndTime");
            this.Property(t => t.RegistReason).HasColumnName("RegistReason");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
        }
    }
}
