using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class DiyTypePTypeIDMap : EntityTypeConfiguration<DiyTypePTypeID>
    {
        public DiyTypePTypeIDMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Ptypeid, t.Diytypeid });

            // Properties
            this.Property(t => t.Ptypeid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Diytypeid)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DiyTypePTypeID");
            this.Property(t => t.Ptypeid).HasColumnName("Ptypeid");
            this.Property(t => t.Diytypeid).HasColumnName("Diytypeid");
        }
    }
}
