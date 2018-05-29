using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class customchangelogMap : EntityTypeConfiguration<customchangelog>
    {
        public customchangelogMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.dateTime });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ipAddress)
                .HasMaxLength(15);

            this.Property(t => t.formname)
                .HasMaxLength(100);

            this.Property(t => t.datafiled)
                .HasMaxLength(100);

            this.Property(t => t.label)
                .HasMaxLength(100);

            this.Property(t => t.changefiled)
                .HasMaxLength(100);

            this.Property(t => t.logtext)
                .HasMaxLength(300);

            this.Property(t => t.loginUserId)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("customchangelog");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.dateTime).HasColumnName("dateTime");
            this.Property(t => t.ipAddress).HasColumnName("ipAddress");
            this.Property(t => t.formname).HasColumnName("formname");
            this.Property(t => t.datafiled).HasColumnName("datafiled");
            this.Property(t => t.label).HasColumnName("label");
            this.Property(t => t.changefiled).HasColumnName("changefiled");
            this.Property(t => t.logtext).HasColumnName("logtext");
            this.Property(t => t.loginUserId).HasColumnName("loginUserId");
        }
    }
}
