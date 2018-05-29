using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class NVipCardSetLogMap : EntityTypeConfiguration<NVipCardSetLog>
    {
        public NVipCardSetLogMap()
        {
            // Primary Key
            this.HasKey(t => t.iD);

            // Properties
            this.Property(t => t.etypeid)
                .HasMaxLength(50);

            this.Property(t => t.comment)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("NVipCardSetLog");
            this.Property(t => t.iD).HasColumnName("iD");
            this.Property(t => t.updateTime).HasColumnName("updateTime");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.VipCardTypeID).HasColumnName("VipCardTypeID");
            this.Property(t => t.ChangeType).HasColumnName("ChangeType");
            this.Property(t => t.comment).HasColumnName("comment");
        }
    }
}
