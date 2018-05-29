using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ord_PlugInstallLogMap : EntityTypeConfiguration<Ord_PlugInstallLog>
    {
        public Ord_PlugInstallLogMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.plugname)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Ord_PlugInstallLog");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.plugname).HasColumnName("plugname");
            this.Property(t => t.plugid).HasColumnName("plugid");
            this.Property(t => t.XmlContent).HasColumnName("XmlContent");
            this.Property(t => t.installdate).HasColumnName("installdate");
        }
    }
}
