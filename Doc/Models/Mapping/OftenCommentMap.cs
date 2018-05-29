using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OftenCommentMap : EntityTypeConfiguration<OftenComment>
    {
        public OftenCommentMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.UserCode, t.Content });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.UserCode)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Content)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("OftenComment");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.Content).HasColumnName("Content");
        }
    }
}
