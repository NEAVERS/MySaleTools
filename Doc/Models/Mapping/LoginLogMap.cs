using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class LoginLogMap : EntityTypeConfiguration<LoginLog>
    {
        public LoginLogMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.comment)
                .HasMaxLength(200);

            this.Property(t => t.beginloginmp)
                .HasMaxLength(200);

            this.Property(t => t.endloginmp)
                .HasMaxLength(200);

            this.Property(t => t.requeststamp)
                .HasMaxLength(200);

            this.Property(t => t.getstamp)
                .HasMaxLength(200);

            this.Property(t => t.finishstamp)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("LoginLog");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.LogTime).HasColumnName("LogTime");
            this.Property(t => t.comment).HasColumnName("comment");
            this.Property(t => t.beginloginmp).HasColumnName("beginloginmp");
            this.Property(t => t.endloginmp).HasColumnName("endloginmp");
            this.Property(t => t.requeststamp).HasColumnName("requeststamp");
            this.Property(t => t.getstamp).HasColumnName("getstamp");
            this.Property(t => t.finishstamp).HasColumnName("finishstamp");
            this.Property(t => t.flag).HasColumnName("flag");
            this.Property(t => t.timecontrast).HasColumnName("timecontrast");
        }
    }
}
