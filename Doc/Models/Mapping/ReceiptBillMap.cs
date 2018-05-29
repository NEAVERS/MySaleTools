using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class ReceiptBillMap : EntityTypeConfiguration<ReceiptBill>
    {
        public ReceiptBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberID, t.BillType, t.ID, t.RecordedItemId });

            // Properties
            this.Property(t => t.BillNumberID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.KTypeID)
                .HasMaxLength(100);

            this.Property(t => t.PTypeID)
                .HasMaxLength(100);

            this.Property(t => t.Comment)
                .HasMaxLength(255);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            this.Property(t => t.RecordedItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUnitMsg)
                .HasMaxLength(50);

            this.Property(t => t.MUnitMsg)
                .HasMaxLength(50);

            this.Property(t => t.goodsnumber)
                .HasMaxLength(100);

            this.Property(t => t.ProduceDate)
                .HasMaxLength(50);

            this.Property(t => t.ValidDate)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ReceiptBill");
            this.Property(t => t.BillNumberID).HasColumnName("BillNumberID");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.MainBillNumberID).HasColumnName("MainBillNumberID");
            this.Property(t => t.KTypeID).HasColumnName("KTypeID");
            this.Property(t => t.PTypeID).HasColumnName("PTypeID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.Tax).HasColumnName("Tax");
            this.Property(t => t.TaxPrice).HasColumnName("TaxPrice");
            this.Property(t => t.TaxTotal).HasColumnName("TaxTotal");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.discount).HasColumnName("discount");
            this.Property(t => t.BeforePrice).HasColumnName("BeforePrice");
            this.Property(t => t.BeforeTotal).HasColumnName("BeforeTotal");
            this.Property(t => t.RecordedItemId).HasColumnName("RecordedItemId");
            this.Property(t => t.Nprice).HasColumnName("Nprice");
            this.Property(t => t.NTotal).HasColumnName("NTotal");
            this.Property(t => t.NTaxPrice).HasColumnName("NTaxPrice");
            this.Property(t => t.NTaxTotal).HasColumnName("NTaxTotal");
            this.Property(t => t.NTaxMoney).HasColumnName("NTaxMoney");
            this.Property(t => t.CargoID).HasColumnName("CargoID");
            this.Property(t => t.UnitID).HasColumnName("UnitID");
            this.Property(t => t.NUnitID).HasColumnName("NUnitID");
            this.Property(t => t.NQty).HasColumnName("NQty");
            this.Property(t => t.UnitRate).HasColumnName("UnitRate");
            this.Property(t => t.NUnitMsg).HasColumnName("NUnitMsg");
            this.Property(t => t.MUnitID).HasColumnName("MUnitID");
            this.Property(t => t.MQty).HasColumnName("MQty");
            this.Property(t => t.MUnitRate).HasColumnName("MUnitRate");
            this.Property(t => t.MUnitMsg).HasColumnName("MUnitMsg");
            this.Property(t => t.MPrice).HasColumnName("MPrice");
            this.Property(t => t.MTaxPrice).HasColumnName("MTaxPrice");
            this.Property(t => t.CurMPrice).HasColumnName("CurMPrice");
            this.Property(t => t.CurMTaxPrice).HasColumnName("CurMTaxPrice");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.IsCombined).HasColumnName("IsCombined");
            this.Property(t => t.Nbeforeprice).HasColumnName("Nbeforeprice");
            this.Property(t => t.NBeforeTotal).HasColumnName("NBeforeTotal");
            this.Property(t => t.goodsnumber).HasColumnName("goodsnumber");
            this.Property(t => t.saleprice).HasColumnName("saleprice");
            this.Property(t => t.saletotal).HasColumnName("saletotal");
            this.Property(t => t.nsaleprice).HasColumnName("nsaleprice");
            this.Property(t => t.nsaletotal).HasColumnName("nsaletotal");
            this.Property(t => t.curmsaleprice).HasColumnName("curmsaleprice");
            this.Property(t => t.curmsaletotal).HasColumnName("curmsaletotal");
            this.Property(t => t.taxmoney).HasColumnName("taxmoney");
            this.Property(t => t.CompleteQty).HasColumnName("CompleteQty");
            this.Property(t => t.CompleteTotal).HasColumnName("CompleteTotal");
            this.Property(t => t.NCompleteTotal).HasColumnName("NCompleteTotal");
            this.Property(t => t.IsGift).HasColumnName("IsGift");
            this.Property(t => t.TeamNo).HasColumnName("TeamNo");
            this.Property(t => t.TeamNO1).HasColumnName("TeamNO1");
            this.Property(t => t.InvoiceCostTotal).HasColumnName("InvoiceCostTotal");
            this.Property(t => t.MainBillType).HasColumnName("MainBillType");
            this.Property(t => t.InvoiceCostPrice).HasColumnName("InvoiceCostPrice");
            this.Property(t => t.ProduceDate).HasColumnName("ProduceDate");
            this.Property(t => t.ValidDate).HasColumnName("ValidDate");
            this.Property(t => t.Serial).HasColumnName("Serial");
            this.Property(t => t.ShowOrder).HasColumnName("ShowOrder");
        }
    }
}
