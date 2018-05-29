using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class upgradeVersionListMap : EntityTypeConfiguration<upgradeVersionList>
    {
        public upgradeVersionListMap()
        {
            // Primary Key
            this.HasKey(t => t.UpgradeId);

            // Properties
            this.Property(t => t.oldVersion)
                .HasMaxLength(100);

            this.Property(t => t.oldMidVersion)
                .HasMaxLength(100);

            this.Property(t => t.newVersion)
                .HasMaxLength(100);

            this.Property(t => t.newMidVersion)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("upgradeVersionList");
            this.Property(t => t.UpgradeId).HasColumnName("UpgradeId");
            this.Property(t => t.oldVersion).HasColumnName("oldVersion");
            this.Property(t => t.oldMidVersion).HasColumnName("oldMidVersion");
            this.Property(t => t.newVersion).HasColumnName("newVersion");
            this.Property(t => t.newMidVersion).HasColumnName("newMidVersion");
            this.Property(t => t.UpgradeDate).HasColumnName("UpgradeDate");
        }
    }
}
