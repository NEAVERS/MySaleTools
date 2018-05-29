using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class UFO_DefineFucTypeMap : EntityTypeConfiguration<UFO_DefineFucType>
    {
        public UFO_DefineFucTypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.TypeName });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TypeName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("UFO_DefineFucType");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TypeName).HasColumnName("TypeName");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
        }
    }
}
