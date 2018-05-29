using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class UserconfigMap : EntityTypeConfiguration<Userconfig>
    {
        public UserconfigMap()
        {
            // Primary Key
            this.HasKey(t => t.ConfigNo);

            // Properties
            this.Property(t => t.ConfigName)
                .HasMaxLength(50);

            this.Property(t => t.Value)
                .HasMaxLength(5000);

            this.Property(t => t.EtypeId)
                .HasMaxLength(50);

            this.Property(t => t.IsAll)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Userconfig");
            this.Property(t => t.ConfigNo).HasColumnName("ConfigNo");
            this.Property(t => t.ConfigName).HasColumnName("ConfigName");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.EtypeId).HasColumnName("EtypeId");
            this.Property(t => t.IsAll).HasColumnName("IsAll");
        }
    }
}
