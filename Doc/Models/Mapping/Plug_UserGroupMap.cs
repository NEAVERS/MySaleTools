using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Plug_UserGroupMap : EntityTypeConfiguration<Plug_UserGroup>
    {
        public Plug_UserGroupMap()
        {
            // Primary Key
            this.HasKey(t => new { t.UgId, t.plugid, t.limitid, t.lim });

            // Properties
            this.Property(t => t.UgId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.plugid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.limitid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.lim)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Plug_UserGroup");
            this.Property(t => t.UgId).HasColumnName("UgId");
            this.Property(t => t.plugid).HasColumnName("plugid");
            this.Property(t => t.limitid).HasColumnName("limitid");
            this.Property(t => t.lim).HasColumnName("lim");
        }
    }
}
