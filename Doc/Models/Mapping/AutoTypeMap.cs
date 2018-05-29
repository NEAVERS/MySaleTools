using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class AutoTypeMap : EntityTypeConfiguration<AutoType>
    {
        public AutoTypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.fullname });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.fullname)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.comment)
                .HasMaxLength(1000);

            this.Property(t => t.PYCode)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("AutoType");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.fullname).HasColumnName("fullname");
            this.Property(t => t.comment).HasColumnName("comment");
            this.Property(t => t.PYCode).HasColumnName("PYCode");
        }
    }
}
