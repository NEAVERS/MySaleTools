using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class SMS_CODEMOBIL_SETMap : EntityTypeConfiguration<SMS_CODEMOBIL_SET>
    {
        public SMS_CODEMOBIL_SETMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.QRYCODE, t.MOBIL });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.QRYCODE)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.MOBIL)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("SMS_CODEMOBIL_SET");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.QRYCODE).HasColumnName("QRYCODE");
            this.Property(t => t.MOBIL).HasColumnName("MOBIL");
        }
    }
}
