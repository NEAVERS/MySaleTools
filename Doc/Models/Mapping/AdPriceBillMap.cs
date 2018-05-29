using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class AdPriceBillMap : EntityTypeConfiguration<AdPriceBill>
    {
        public AdPriceBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.IsUnit2, t.ID, t.ktypeid, t.Type });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            this.Property(t => t.PtypeId)
                .HasMaxLength(50);

            this.Property(t => t.JobNumber)
                .HasMaxLength(20);

            this.Property(t => t.IsUnit2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.GoodsNumber)
                .HasMaxLength(100);

            this.Property(t => t.ProduceDate)
                .HasMaxLength(50);

            this.Property(t => t.ValidDate)
                .HasMaxLength(50);

            this.Property(t => t.GoodsBTypeID)
                .HasMaxLength(50);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            this.Property(t => t.ktypeid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Type)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AdPriceBill");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.PtypeId).HasColumnName("PtypeId");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.BeforePrice).HasColumnName("BeforePrice");
            this.Property(t => t.BeforeTotal).HasColumnName("BeforeTotal");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.total).HasColumnName("total");
            this.Property(t => t.JobNumber).HasColumnName("JobNumber");
            this.Property(t => t.GoodsNo).HasColumnName("GoodsNo");
            this.Property(t => t.OutFactoryDate).HasColumnName("OutFactoryDate");
            this.Property(t => t.IsUnit2).HasColumnName("IsUnit2");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ChangeAllStock).HasColumnName("ChangeAllStock");
            this.Property(t => t.InputCostPrice).HasColumnName("InputCostPrice");
            this.Property(t => t.GoodsOrder).HasColumnName("GoodsOrder");
            this.Property(t => t.GoodsNumber).HasColumnName("GoodsNumber");
            this.Property(t => t.ProduceDate).HasColumnName("ProduceDate");
            this.Property(t => t.ValidDate).HasColumnName("ValidDate");
            this.Property(t => t.GoodsBTypeID).HasColumnName("GoodsBTypeID");
            this.Property(t => t.GoodsCostPrice).HasColumnName("GoodsCostPrice");
            this.Property(t => t.GoodsCostTotal).HasColumnName("GoodsCostTotal");
            this.Property(t => t.HandZeroCost).HasColumnName("HandZeroCost");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.ktypeid).HasColumnName("ktypeid");
            this.Property(t => t.Serial).HasColumnName("Serial");
            this.Property(t => t.NPrice).HasColumnName("NPrice");
            this.Property(t => t.NTotal).HasColumnName("NTotal");
            this.Property(t => t.FromBillNumberID).HasColumnName("FromBillNumberID");
            this.Property(t => t.FromBillType).HasColumnName("FromBillType");
            this.Property(t => t.FromBillID).HasColumnName("FromBillID");
            this.Property(t => t.ShowOrder).HasColumnName("ShowOrder");
            this.Property(t => t.ChangeTotal).HasColumnName("ChangeTotal");
            this.Property(t => t.NQty).HasColumnName("NQty");
            this.Property(t => t.UnitRate).HasColumnName("UnitRate");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.IsCombined).HasColumnName("IsCombined");
            this.Property(t => t.cargoID).HasColumnName("cargoID");
            this.Property(t => t.Type).HasColumnName("Type");
        }
    }
}
