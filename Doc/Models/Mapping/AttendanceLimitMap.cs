using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class AttendanceLimitMap : EntityTypeConfiguration<AttendanceLimit>
    {
        public AttendanceLimitMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Islimit, t.MacAddress, t.HardDiskNo, t.IPAddress });

            // Properties
            this.Property(t => t.etypeid)
                .HasMaxLength(50);

            this.Property(t => t.Islimit)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MacAddress)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.HardDiskNo)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.IPAddress)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AttendanceLimit");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.Islimit).HasColumnName("Islimit");
            this.Property(t => t.MacAddress).HasColumnName("MacAddress");
            this.Property(t => t.HardDiskNo).HasColumnName("HardDiskNo");
            this.Property(t => t.IPAddress).HasColumnName("IPAddress");
        }
    }
}
