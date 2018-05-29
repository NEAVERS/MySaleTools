using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class SMS_GROUPCODE_SETMap : EntityTypeConfiguration<SMS_GROUPCODE_SET>
    {
        public SMS_GROUPCODE_SETMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.GID, t.QRYCODE });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.GID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.QRYCODE)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("SMS_GROUPCODE_SET");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.GID).HasColumnName("GID");
            this.Property(t => t.QRYCODE).HasColumnName("QRYCODE");
        }
    }
}
