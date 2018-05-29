using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosSaleBillAllMap : EntityTypeConfiguration<PosSaleBillAll>
    {
        public PosSaleBillAllMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PromoType, t.SaleEid, t.producedate, t.validdate, t.goodsnumber, t.serial });

            // Properties
            this.Property(t => t.BarCode)
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(255);

            this.Property(t => t.PromoType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SaleEid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.producedate)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.validdate)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.goodsnumber)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.serial)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("PosSaleBillAll");
            this.Property(t => t.BillnumberID).HasColumnName("BillnumberID");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PID).HasColumnName("PID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.BackQty).HasColumnName("BackQty");
            this.Property(t => t.RetailPrice).HasColumnName("RetailPrice");
            this.Property(t => t.Tax).HasColumnName("Tax");
            this.Property(t => t.DisCount).HasColumnName("DisCount");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.RetailTotal).HasColumnName("RetailTotal");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.UnitID).HasColumnName("UnitID");
            this.Property(t => t.UnitRate).HasColumnName("UnitRate");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.IsCombined).HasColumnName("IsCombined");
            this.Property(t => t.BarCode).HasColumnName("BarCode");
            this.Property(t => t.IsGift).HasColumnName("IsGift");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.BaseUnitID).HasColumnName("BaseUnitID");
            this.Property(t => t.PromoType).HasColumnName("PromoType");
            this.Property(t => t.SaleEid).HasColumnName("SaleEid");
            this.Property(t => t.producedate).HasColumnName("producedate");
            this.Property(t => t.validdate).HasColumnName("validdate");
            this.Property(t => t.goodsnumber).HasColumnName("goodsnumber");
            this.Property(t => t.serial).HasColumnName("serial");
            this.Property(t => t.goodscostprice).HasColumnName("goodscostprice");
            this.Property(t => t.paymoney).HasColumnName("paymoney");
        }
    }
}
