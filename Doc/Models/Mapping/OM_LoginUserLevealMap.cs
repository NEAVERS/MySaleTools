using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OM_LoginUserLevealMap : EntityTypeConfiguration<OM_LoginUserLeveal>
    {
        public OM_LoginUserLevealMap()
        {
            // Primary Key
            this.HasKey(t => new { t.TypeID, t.FullName });

            // Properties
            this.Property(t => t.TypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Remark)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("OM_LoginUserLeveal");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}
