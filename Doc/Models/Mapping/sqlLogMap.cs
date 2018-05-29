using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class sqlLogMap : EntityTypeConfiguration<sqlLog>
    {
        public sqlLogMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.type, t.dateTime, t.elapsed, t.url, t.C_sql, t.executeElapsed, t.fetchElapsed, t.C_rowCount });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.elapsed)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.url)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.params)
                .HasMaxLength(1000);

            this.Property(t => t.ipAddress)
                .HasMaxLength(15);

            this.Property(t => t.C_sql)
                .IsRequired()
                .HasMaxLength(8000);

            this.Property(t => t.executeElapsed)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.fetchElapsed)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.C_rowCount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.error)
                .HasMaxLength(400);

            this.Property(t => t.profileId)
                .HasMaxLength(100);

            this.Property(t => t.loginUserId)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("sqlLog");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.dateTime).HasColumnName("dateTime");
            this.Property(t => t.elapsed).HasColumnName("elapsed");
            this.Property(t => t.url).HasColumnName("url");
            this.Property(t => t.params).HasColumnName("params");
            this.Property(t => t.ipAddress).HasColumnName("ipAddress");
            this.Property(t => t.C_sql).HasColumnName("_sql");
            this.Property(t => t.executeElapsed).HasColumnName("executeElapsed");
            this.Property(t => t.fetchElapsed).HasColumnName("fetchElapsed");
            this.Property(t => t.C_rowCount).HasColumnName("_rowCount");
            this.Property(t => t.error).HasColumnName("error");
            this.Property(t => t.profileId).HasColumnName("profileId");
            this.Property(t => t.loginUserId).HasColumnName("loginUserId");
        }
    }
}
