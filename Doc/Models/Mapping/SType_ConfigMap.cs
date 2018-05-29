using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class SType_ConfigMap : EntityTypeConfiguration<SType_Config>
    {
        public SType_ConfigMap()
        {
            // Primary Key
            this.HasKey(t => t.ConfigNo);

            // Properties
            this.Property(t => t.ConfigNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ConfigName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SType_Config");
            this.Property(t => t.ConfigNo).HasColumnName("ConfigNo");
            this.Property(t => t.ConfigName).HasColumnName("ConfigName");
        }
    }
}
