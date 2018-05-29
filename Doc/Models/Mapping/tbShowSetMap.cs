using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class tbShowSetMap : EntityTypeConfiguration<tbShowSet>
    {
        public tbShowSetMap()
        {
            // Primary Key
            this.HasKey(t => new { t.No, t.FullName });

            // Properties
            this.Property(t => t.No)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UserCode)
                .HasMaxLength(50);

            this.Property(t => t.TypeId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tbShowSet");
            this.Property(t => t.No).HasColumnName("No");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
            this.Property(t => t.IfShow).HasColumnName("IfShow");
        }
    }
}
