using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class UserGroupMap : EntityTypeConfiguration<UserGroup>
    {
        public UserGroupMap()
        {
            // Primary Key
            this.HasKey(t => new { t.UgId, t.ugname });

            // Properties
            this.Property(t => t.UgId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ugname)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.lim)
                .HasMaxLength(5000);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            this.Property(t => t.etypeid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("UserGroup");
            this.Property(t => t.UgId).HasColumnName("UgId");
            this.Property(t => t.ugname).HasColumnName("ugname");
            this.Property(t => t.lim).HasColumnName("lim");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
        }
    }
}
