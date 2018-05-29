using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class customPtypeItemMap : EntityTypeConfiguration<customPtypeItem>
    {
        public customPtypeItemMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.usercode)
                .HasMaxLength(300);

            this.Property(t => t.fullname)
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("customPtypeItems");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.usercode).HasColumnName("usercode");
            this.Property(t => t.fullname).HasColumnName("fullname");
            this.Property(t => t.referenceIdList).HasColumnName("referenceIdList");
            this.Property(t => t.isUse).HasColumnName("isUse");
        }
    }
}
