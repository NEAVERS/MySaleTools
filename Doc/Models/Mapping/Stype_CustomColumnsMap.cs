using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Stype_CustomColumnsMap : EntityTypeConfiguration<Stype_CustomColumns>
    {
        public Stype_CustomColumnsMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.typeid)
                .HasMaxLength(100);

            this.Property(t => t.Costom1)
                .HasMaxLength(600);

            this.Property(t => t.Costom2)
                .HasMaxLength(600);

            this.Property(t => t.Costom3)
                .HasMaxLength(600);

            this.Property(t => t.Costom4)
                .HasMaxLength(600);

            this.Property(t => t.Costom5)
                .HasMaxLength(600);

            this.Property(t => t.Costom6)
                .HasMaxLength(600);

            this.Property(t => t.Costom7)
                .HasMaxLength(600);

            this.Property(t => t.Costom8)
                .HasMaxLength(600);

            this.Property(t => t.Costom9)
                .HasMaxLength(600);

            this.Property(t => t.Costom10)
                .HasMaxLength(600);

            this.Property(t => t.Costom11)
                .HasMaxLength(600);

            this.Property(t => t.Costom12)
                .HasMaxLength(600);

            this.Property(t => t.Costom13)
                .HasMaxLength(600);

            this.Property(t => t.Costom14)
                .HasMaxLength(600);

            this.Property(t => t.Costom15)
                .HasMaxLength(600);

            this.Property(t => t.Costom16)
                .HasMaxLength(600);

            this.Property(t => t.Costom17)
                .HasMaxLength(600);

            this.Property(t => t.Costom18)
                .HasMaxLength(600);

            this.Property(t => t.Costom19)
                .HasMaxLength(600);

            this.Property(t => t.Costom20)
                .HasMaxLength(600);

            // Table & Column Mappings
            this.ToTable("Stype_CustomColumns");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.typeid).HasColumnName("typeid");
            this.Property(t => t.Costom1).HasColumnName("Costom1");
            this.Property(t => t.Costom2).HasColumnName("Costom2");
            this.Property(t => t.Costom3).HasColumnName("Costom3");
            this.Property(t => t.Costom4).HasColumnName("Costom4");
            this.Property(t => t.Costom5).HasColumnName("Costom5");
            this.Property(t => t.Costom6).HasColumnName("Costom6");
            this.Property(t => t.Costom7).HasColumnName("Costom7");
            this.Property(t => t.Costom8).HasColumnName("Costom8");
            this.Property(t => t.Costom9).HasColumnName("Costom9");
            this.Property(t => t.Costom10).HasColumnName("Costom10");
            this.Property(t => t.Costom11).HasColumnName("Costom11");
            this.Property(t => t.Costom12).HasColumnName("Costom12");
            this.Property(t => t.Costom13).HasColumnName("Costom13");
            this.Property(t => t.Costom14).HasColumnName("Costom14");
            this.Property(t => t.Costom15).HasColumnName("Costom15");
            this.Property(t => t.Costom16).HasColumnName("Costom16");
            this.Property(t => t.Costom17).HasColumnName("Costom17");
            this.Property(t => t.Costom18).HasColumnName("Costom18");
            this.Property(t => t.Costom19).HasColumnName("Costom19");
            this.Property(t => t.Costom20).HasColumnName("Costom20");
        }
    }
}
