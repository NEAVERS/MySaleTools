using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class SMS_GROUPNAME_SETMap : EntityTypeConfiguration<SMS_GROUPNAME_SET>
    {
        public SMS_GROUPNAME_SETMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.GNAME });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.GNAME)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("SMS_GROUPNAME_SET");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.GNAME).HasColumnName("GNAME");
        }
    }
}
