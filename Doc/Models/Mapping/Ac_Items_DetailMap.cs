using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_Items_DetailMap : EntityTypeConfiguration<Ac_Items_Detail>
    {
        public Ac_Items_DetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DId);

            // Properties
            this.Property(t => t.STypeId)
                .HasMaxLength(50);

            this.Property(t => t.ATypeId)
                .HasMaxLength(50);

            this.Property(t => t.DepATypeId)
                .HasMaxLength(50);

            this.Property(t => t.DisATypeId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Ac_Items_Detail");
            this.Property(t => t.DId).HasColumnName("DId");
            this.Property(t => t.nId).HasColumnName("nId");
            this.Property(t => t.STypeId).HasColumnName("STypeId");
            this.Property(t => t.ATypeId).HasColumnName("ATypeId");
            this.Property(t => t.DepATypeId).HasColumnName("DepATypeId");
            this.Property(t => t.DisATypeId).HasColumnName("DisATypeId");
            this.Property(t => t.XiWaMaxNumber).HasColumnName("XiWaMaxNumber");
        }
    }
}
