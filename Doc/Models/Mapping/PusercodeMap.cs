using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PusercodeMap : EntityTypeConfiguration<Pusercode>
    {
        public PusercodeMap()
        {
            // Primary Key
            this.HasKey(t => t.usercode);

            // Properties
            this.Property(t => t.ptypeid)
                .HasMaxLength(50);

            this.Property(t => t.btypeid)
                .HasMaxLength(50);

            this.Property(t => t.usercode)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Pusercode");
            this.Property(t => t.ptypeid).HasColumnName("ptypeid");
            this.Property(t => t.btypeid).HasColumnName("btypeid");
            this.Property(t => t.usercode).HasColumnName("usercode");
        }
    }
}
