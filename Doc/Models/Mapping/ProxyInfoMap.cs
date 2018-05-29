using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class ProxyInfoMap : EntityTypeConfiguration<ProxyInfo>
    {
        public ProxyInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.CompName)
                .HasMaxLength(500);

            this.Property(t => t.LinkAddr)
                .HasMaxLength(500);

            this.Property(t => t.LinkPhone)
                .HasMaxLength(500);

            this.Property(t => t.Email)
                .HasMaxLength(500);

            this.Property(t => t.LinkMan)
                .HasMaxLength(500);

            this.Property(t => t.Note)
                .HasMaxLength(8000);

            // Table & Column Mappings
            this.ToTable("ProxyInfo");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CompName).HasColumnName("CompName");
            this.Property(t => t.LinkAddr).HasColumnName("LinkAddr");
            this.Property(t => t.LinkPhone).HasColumnName("LinkPhone");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.LinkMan).HasColumnName("LinkMan");
            this.Property(t => t.Note).HasColumnName("Note");
        }
    }
}
