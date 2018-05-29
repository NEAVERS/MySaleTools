using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class VipCardAutoZkMap : EntityTypeConfiguration<VipCardAutoZk>
    {
        public VipCardAutoZkMap()
        {
            // Primary Key
            this.HasKey(t => t.VipCardAutoID);

            // Properties
            this.Property(t => t.Note)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("VipCardAutoZk");
            this.Property(t => t.VipCardAutoID).HasColumnName("VipCardAutoID");
            this.Property(t => t.VipCardId).HasColumnName("VipCardId");
            this.Property(t => t.ZkHighLimit).HasColumnName("ZkHighLimit");
            this.Property(t => t.ZkLowLimit).HasColumnName("ZkLowLimit");
            this.Property(t => t.ZkAutoRate).HasColumnName("ZkAutoRate");
            this.Property(t => t.Note).HasColumnName("Note");
        }
    }
}
