using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ord_AssemblyInfoMap : EntityTypeConfiguration<Ord_AssemblyInfo>
    {
        public Ord_AssemblyInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Destinationalpath)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ServerTemppath)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.type)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Ord_AssemblyInfo");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PlugId).HasColumnName("PlugId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Destinationalpath).HasColumnName("Destinationalpath");
            this.Property(t => t.ServerTemppath).HasColumnName("ServerTemppath");
            this.Property(t => t.type).HasColumnName("type");
        }
    }
}
