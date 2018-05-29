using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class AssetIncDecBillMap : EntityTypeConfiguration<AssetIncDecBill>
    {
        public AssetIncDecBillMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Comment)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("AssetIncDecBill");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.AssetCardId).HasColumnName("AssetCardId");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.NTotal).HasColumnName("NTotal");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.Tax).HasColumnName("Tax");
            this.Property(t => t.NTaxMoney).HasColumnName("NTaxMoney");
            this.Property(t => t.TaxMoney).HasColumnName("TaxMoney");
            this.Property(t => t.NTaxTotal).HasColumnName("NTaxTotal");
            this.Property(t => t.TaxTotal).HasColumnName("TaxTotal");
            this.Property(t => t.NDepTotal).HasColumnName("NDepTotal");
            this.Property(t => t.DepTotal).HasColumnName("DepTotal");
            this.Property(t => t.NNetValue).HasColumnName("NNetValue");
            this.Property(t => t.NetValue).HasColumnName("NetValue");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
