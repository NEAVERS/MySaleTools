using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ord_PlugMap : EntityTypeConfiguration<Ord_Plug>
    {
        public Ord_PlugMap()
        {
            // Primary Key
            this.HasKey(t => t.PlugName);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.PlugName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.AppropriateVerSion)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.XmlPath)
                .HasMaxLength(200);

            this.Property(t => t.plugversion)
                .HasMaxLength(50);

            this.Property(t => t.plugfuncdescription)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("Ord_Plug");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PlugName).HasColumnName("PlugName");
            this.Property(t => t.AppropriateVerSion).HasColumnName("AppropriateVerSion");
            this.Property(t => t.XmlPath).HasColumnName("XmlPath");
            this.Property(t => t.IsInstalled).HasColumnName("IsInstalled");
            this.Property(t => t.plugversion).HasColumnName("plugversion");
            this.Property(t => t.plugfuncdescription).HasColumnName("plugfuncdescription");
            this.Property(t => t.InstallDate).HasColumnName("InstallDate");
        }
    }
}
