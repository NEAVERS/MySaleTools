using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class sms_logMap : EntityTypeConfiguration<sms_log>
    {
        public sms_logMap()
        {
            // Primary Key
            this.HasKey(t => new { t.LogID, t.MOBIL, t.SendTime, t.Content, t.SendId });

            // Properties
            this.Property(t => t.LogID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.MOBIL)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.OperID)
                .HasMaxLength(50);

            this.Property(t => t.Content)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.SendId)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("sms_log");
            this.Property(t => t.LogID).HasColumnName("LogID");
            this.Property(t => t.nType).HasColumnName("nType");
            this.Property(t => t.MOBIL).HasColumnName("MOBIL");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.SendTime).HasColumnName("SendTime");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.SendId).HasColumnName("SendId");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
        }
    }
}
