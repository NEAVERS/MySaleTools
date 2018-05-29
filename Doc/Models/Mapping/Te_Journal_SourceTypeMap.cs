using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Te_Journal_SourceTypeMap : EntityTypeConfiguration<Te_Journal_SourceType>
    {
        public Te_Journal_SourceTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.FullName);

            // Properties
            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Te_Journal_SourceType");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FullName).HasColumnName("FullName");
        }
    }
}
