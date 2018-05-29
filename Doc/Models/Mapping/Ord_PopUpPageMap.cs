using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ord_PopUpPageMap : EntityTypeConfiguration<Ord_PopUpPage>
    {
        public Ord_PopUpPageMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.NameSpaceAndClass)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.NeedLoadAssembly)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.paramlist)
                .HasMaxLength(200);

            this.Property(t => t.replacemenuid)
                .HasMaxLength(20);

            this.Property(t => t.webmenuname)
                .HasMaxLength(2000);

            this.Property(t => t.menuguid)
                .HasMaxLength(40);

            this.Property(t => t.xapname)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Ord_PopUpPage");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PlugId).HasColumnName("PlugId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.parentmenuid).HasColumnName("parentmenuid");
            this.Property(t => t.NameSpaceAndClass).HasColumnName("NameSpaceAndClass");
            this.Property(t => t.NeedLoadAssembly).HasColumnName("NeedLoadAssembly");
            this.Property(t => t.Offset).HasColumnName("Offset");
            this.Property(t => t.ismdi).HasColumnName("ismdi");
            this.Property(t => t.paramlist).HasColumnName("paramlist");
            this.Property(t => t.replacemenuid).HasColumnName("replacemenuid");
            this.Property(t => t.menutype).HasColumnName("menutype");
            this.Property(t => t.webmenuname).HasColumnName("webmenuname");
            this.Property(t => t.menuguid).HasColumnName("menuguid");
            this.Property(t => t.xapname).HasColumnName("xapname");
        }
    }
}
