using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class RequestBillMap : EntityTypeConfiguration<RequestBill>
    {
        public RequestBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.ID });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PtypeId)
                .HasMaxLength(50);

            this.Property(t => t.comment)
                .HasMaxLength(500);

            this.Property(t => t.FeedBack)
                .HasMaxLength(500);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            this.Property(t => t.Btypeid)
                .HasMaxLength(50);

            this.Property(t => t.Etypeid)
                .HasMaxLength(50);

            this.Property(t => t.Btypeid2)
                .HasMaxLength(50);

            this.Property(t => t.NUnitMsg)
                .HasMaxLength(50);

            this.Property(t => t.MUnitMsg)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("RequestBill");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.PtypeId).HasColumnName("PtypeId");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.SalePrice).HasColumnName("SalePrice");
            this.Property(t => t.discount).HasColumnName("discount");
            this.Property(t => t.DiscountPrice).HasColumnName("DiscountPrice");
            this.Property(t => t.total).HasColumnName("total");
            this.Property(t => t.TaxPrice).HasColumnName("TaxPrice");
            this.Property(t => t.TaxTotal).HasColumnName("TaxTotal");
            this.Property(t => t.comment).HasColumnName("comment");
            this.Property(t => t.FeedBack).HasColumnName("FeedBack");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SaleTotal).HasColumnName("SaleTotal");
            this.Property(t => t.Tax).HasColumnName("Tax");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.RequestDate).HasColumnName("RequestDate");
            this.Property(t => t.OrderDate).HasColumnName("OrderDate");
            this.Property(t => t.Btypeid).HasColumnName("Btypeid");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Etypeid).HasColumnName("Etypeid");
            this.Property(t => t.Btypeid2).HasColumnName("Btypeid2");
            this.Property(t => t.ComparePrice).HasColumnName("ComparePrice");
            this.Property(t => t.CompareDiscount).HasColumnName("CompareDiscount");
            this.Property(t => t.TaxMoney).HasColumnName("TaxMoney");
            this.Property(t => t.NSalePrice).HasColumnName("NSalePrice");
            this.Property(t => t.NSaleTotal).HasColumnName("NSaleTotal");
            this.Property(t => t.NDiscountPrice).HasColumnName("NDiscountPrice");
            this.Property(t => t.NTotal).HasColumnName("NTotal");
            this.Property(t => t.NTaxPrice).HasColumnName("NTaxPrice");
            this.Property(t => t.NTaxTotal).HasColumnName("NTaxTotal");
            this.Property(t => t.NTaxMoney).HasColumnName("NTaxMoney");
            this.Property(t => t.NCompleteTotal).HasColumnName("NCompleteTotal");
            this.Property(t => t.UnitID).HasColumnName("UnitID");
            this.Property(t => t.NUnitID).HasColumnName("NUnitID");
            this.Property(t => t.NQty).HasColumnName("NQty");
            this.Property(t => t.UnitRate).HasColumnName("UnitRate");
            this.Property(t => t.NUnitMsg).HasColumnName("NUnitMsg");
            this.Property(t => t.MUnitID).HasColumnName("MUnitID");
            this.Property(t => t.MQty).HasColumnName("MQty");
            this.Property(t => t.MUnitRate).HasColumnName("MUnitRate");
            this.Property(t => t.MUnitMsg).HasColumnName("MUnitMsg");
            this.Property(t => t.MSalePrice).HasColumnName("MSalePrice");
            this.Property(t => t.MDiscountPrice).HasColumnName("MDiscountPrice");
            this.Property(t => t.MTaxPrice).HasColumnName("MTaxPrice");
            this.Property(t => t.CurMSalePrice).HasColumnName("CurMSalePrice");
            this.Property(t => t.CurMDiscountPrice).HasColumnName("CurMDiscountPrice");
            this.Property(t => t.CurMTaxPrice).HasColumnName("CurMTaxPrice");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.IsCombined).HasColumnName("IsCombined");
            this.Property(t => t.ShowOrder).HasColumnName("ShowOrder");
            this.Property(t => t.CompareTax).HasColumnName("CompareTax");
            this.Property(t => t.RequestQty).HasColumnName("RequestQty");
        }
    }
}
