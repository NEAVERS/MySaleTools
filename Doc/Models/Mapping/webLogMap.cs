using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class webLogMap : EntityTypeConfiguration<webLog>
    {
        public webLogMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.type, t.status, t.dateTime, t.elapsed, t.businessElapsed, t.url });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.status)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.elapsed)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.businessElapsed)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.url)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.params)
                .HasMaxLength(1000);

            this.Property(t => t.referrer)
                .HasMaxLength(200);

            this.Property(t => t.ipAddress)
                .HasMaxLength(15);

            this.Property(t => t.ipLocation)
                .HasMaxLength(100);

            this.Property(t => t.browser)
                .HasMaxLength(200);

            this.Property(t => t.profileId)
                .HasMaxLength(100);

            this.Property(t => t.loginUserId)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("webLog");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.dateTime).HasColumnName("dateTime");
            this.Property(t => t.elapsed).HasColumnName("elapsed");
            this.Property(t => t.businessElapsed).HasColumnName("businessElapsed");
            this.Property(t => t.url).HasColumnName("url");
            this.Property(t => t.params).HasColumnName("params");
            this.Property(t => t.referrer).HasColumnName("referrer");
            this.Property(t => t.ipAddress).HasColumnName("ipAddress");
            this.Property(t => t.ipLocation).HasColumnName("ipLocation");
            this.Property(t => t.browser).HasColumnName("browser");
            this.Property(t => t.profileId).HasColumnName("profileId");
            this.Property(t => t.loginUserId).HasColumnName("loginUserId");
        }
    }
}
