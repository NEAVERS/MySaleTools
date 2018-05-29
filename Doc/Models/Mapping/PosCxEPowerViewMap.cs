using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosCxEPowerViewMap : EntityTypeConfiguration<PosCxEPowerView>
    {
        public PosCxEPowerViewMap()
        {
            // Primary Key
            this.HasKey(t => t.etypeid);

            // Properties
            this.Property(t => t.etypeid)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.moduleid)
                .HasMaxLength(30);

            this.Property(t => t.actionid)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("PosCxEPowerView");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.moduleid).HasColumnName("moduleid");
            this.Property(t => t.actionid).HasColumnName("actionid");
        }
    }
}
