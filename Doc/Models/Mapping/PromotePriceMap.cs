using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PromotePriceMap : EntityTypeConfiguration<PromotePrice>
    {
        public PromotePriceMap()
        {
            // Primary Key
            this.HasKey(t => t.PromoteId);

            // Properties
            this.Property(t => t.PtypeId)
                .HasMaxLength(50);

            this.Property(t => t.EtypeId)
                .HasMaxLength(50);

            this.Property(t => t.BtypeId)
                .HasMaxLength(50);

            this.Property(t => t.KtypeId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PromotePrice");
            this.Property(t => t.PromoteId).HasColumnName("PromoteId");
            this.Property(t => t.PtypeId).HasColumnName("PtypeId");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.PromotePrice1).HasColumnName("PromotePrice");
            this.Property(t => t.EtypeId).HasColumnName("EtypeId");
            this.Property(t => t.WriteDate).HasColumnName("WriteDate");
            this.Property(t => t.BtypeId).HasColumnName("BtypeId");
            this.Property(t => t.KtypeId).HasColumnName("KtypeId");
        }
    }
}
