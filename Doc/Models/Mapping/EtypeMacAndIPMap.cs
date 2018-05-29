using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class EtypeMacAndIPMap : EntityTypeConfiguration<EtypeMacAndIP>
    {
        public EtypeMacAndIPMap()
        {
            // Primary Key
            this.HasKey(t => t.etypeid);

            // Properties
            this.Property(t => t.etypeid)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.macaddress)
                .HasMaxLength(200);

            this.Property(t => t.harddiskno)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("EtypeMacAndIP");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.macaddress).HasColumnName("macaddress");
            this.Property(t => t.harddiskno).HasColumnName("harddiskno");
        }
    }
}
