using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class vWeb_BtypeARMap : EntityTypeConfiguration<vWeb_BtypeAR>
    {
        public vWeb_BtypeARMap()
        {
            // Primary Key
            this.HasKey(t => t.FullName);

            // Properties
            this.Property(t => t.TypeId)
                .HasMaxLength(50);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(66);

            this.Property(t => t.STypeId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("vWeb_BtypeAR");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.STypeId).HasColumnName("STypeId");
            this.Property(t => t.artotal).HasColumnName("artotal");
            this.Property(t => t.ystotal).HasColumnName("ystotal");
            this.Property(t => t.aptotal).HasColumnName("aptotal");
            this.Property(t => t.yftotal).HasColumnName("yftotal");
            this.Property(t => t.ARLimit).HasColumnName("ARLimit");
            this.Property(t => t.fhje).HasColumnName("fhje");
        }
    }
}
