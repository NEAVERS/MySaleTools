using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_FixedAssetsInit_StypeMap : EntityTypeConfiguration<Ac_FixedAssetsInit_Stype>
    {
        public Ac_FixedAssetsInit_StypeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.StypeId)
                .HasMaxLength(50);

            this.Property(t => t.EtypeId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Ac_FixedAssetsInit_Stype");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.StypeId).HasColumnName("StypeId");
            this.Property(t => t.FYear).HasColumnName("FYear");
            this.Property(t => t.FPeriod).HasColumnName("FPeriod");
            this.Property(t => t.EtypeId).HasColumnName("EtypeId");
            this.Property(t => t.InitDate).HasColumnName("InitDate");
        }
    }
}
