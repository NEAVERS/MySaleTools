using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class IniCommissionStockMap : EntityTypeConfiguration<IniCommissionStock>
    {
        public IniCommissionStockMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Ptypeid, t.Btypeid, t.Type });

            // Properties
            this.Property(t => t.Ptypeid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Btypeid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Type)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.explain)
                .HasMaxLength(256);

            this.Property(t => t.KtypeId)
                .HasMaxLength(50);

            this.Property(t => t.EtypeId)
                .HasMaxLength(50);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("IniCommissionStock");
            this.Property(t => t.Ptypeid).HasColumnName("Ptypeid");
            this.Property(t => t.Btypeid).HasColumnName("Btypeid");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.CostTotal).HasColumnName("CostTotal");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.Tax).HasColumnName("Tax");
            this.Property(t => t.TaxTotal).HasColumnName("TaxTotal");
            this.Property(t => t.explain).HasColumnName("explain");
            this.Property(t => t.KtypeId).HasColumnName("KtypeId");
            this.Property(t => t.EtypeId).HasColumnName("EtypeId");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.DealType).HasColumnName("DealType");
            this.Property(t => t.SerialType).HasColumnName("SerialType");
        }
    }
}
