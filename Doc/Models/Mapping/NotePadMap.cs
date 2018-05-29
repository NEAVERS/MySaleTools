using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class NotePadMap : EntityTypeConfiguration<NotePad>
    {
        public NotePadMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.CreateTime, t.Content, t.UserId });

            // Properties
            this.Property(t => t.typeID)
                .HasMaxLength(100);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Content)
                .IsRequired();

            this.Property(t => t.UserId)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("NotePad");
            this.Property(t => t.typeID).HasColumnName("typeID");
            this.Property(t => t.parID).HasColumnName("parID");
            this.Property(t => t.level).HasColumnName("level");
            this.Property(t => t.sonnum).HasColumnName("sonnum");
            this.Property(t => t.soncount).HasColumnName("soncount");
            this.Property(t => t.delete).HasColumnName("delete");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.AlertTime).HasColumnName("AlertTime");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.Flag).HasColumnName("Flag");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.Importance).HasColumnName("Importance");
            this.Property(t => t.ScanTimes).HasColumnName("ScanTimes");
        }
    }
}
