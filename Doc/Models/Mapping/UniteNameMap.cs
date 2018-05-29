using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class UniteNameMap : EntityTypeConfiguration<UniteName>
    {
        public UniteNameMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.UniteName1 });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.UniteName1)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("UniteName");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UniteName1).HasColumnName("UniteName");
        }
    }
}
