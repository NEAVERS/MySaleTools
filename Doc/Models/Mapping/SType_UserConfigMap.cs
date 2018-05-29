using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class SType_UserConfigMap : EntityTypeConfiguration<SType_UserConfig>
    {
        public SType_UserConfigMap()
        {
            // Primary Key
            this.HasKey(t => t.ConfigNo);

            // Properties
            this.Property(t => t.ConfigNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.StypeId)
                .HasMaxLength(50);

            this.Property(t => t.Value)
                .HasMaxLength(50);

            this.Property(t => t.EtypeId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SType_UserConfig");
            this.Property(t => t.ConfigNo).HasColumnName("ConfigNo");
            this.Property(t => t.StypeId).HasColumnName("StypeId");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.EtypeId).HasColumnName("EtypeId");
        }
    }
}
