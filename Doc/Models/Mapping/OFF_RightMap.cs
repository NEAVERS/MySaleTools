using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OFF_RightMap : EntityTypeConfiguration<OFF_Right>
    {
        public OFF_RightMap()
        {
            // Primary Key
            this.HasKey(t => t.FtypeId);

            // Properties
            this.Property(t => t.FtypeId)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.EtypeId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OFF_Right");
            this.Property(t => t.FtypeId).HasColumnName("FtypeId");
            this.Property(t => t.EtypeId).HasColumnName("EtypeId");
            this.Property(t => t.Right).HasColumnName("Right");
        }
    }
}
