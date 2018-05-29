using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class SMS_GROUPMOBIL_SETMap : EntityTypeConfiguration<SMS_GROUPMOBIL_SET>
    {
        public SMS_GROUPMOBIL_SETMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.GID, t.MOBIL });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.GID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MOBIL)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("SMS_GROUPMOBIL_SET");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.GID).HasColumnName("GID");
            this.Property(t => t.MOBIL).HasColumnName("MOBIL");
        }
    }
}
