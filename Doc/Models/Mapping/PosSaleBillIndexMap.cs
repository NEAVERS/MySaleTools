using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosSaleBillIndexMap : EntityTypeConfiguration<PosSaleBillIndex>
    {
        public PosSaleBillIndexMap()
        {
            // Primary Key
            this.HasKey(t => t.BillnumberID);

            // Properties
            this.Property(t => t.billdate)
                .HasMaxLength(20);

            this.Property(t => t.BillCode)
                .HasMaxLength(50);

            this.Property(t => t.PromotionMsg)
                .HasMaxLength(200);

            this.Property(t => t.billtime)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("PosSaleBillIndex");
            this.Property(t => t.BillnumberID).HasColumnName("BillnumberID");
            this.Property(t => t.Billtype).HasColumnName("Billtype");
            this.Property(t => t.billdate).HasColumnName("billdate");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.SID).HasColumnName("SID");
            this.Property(t => t.BID).HasColumnName("BID");
            this.Property(t => t.KID).HasColumnName("KID");
            this.Property(t => t.PosID).HasColumnName("PosID");
            this.Property(t => t.EID).HasColumnName("EID");
            this.Property(t => t.VipCardID).HasColumnName("VipCardID");
            this.Property(t => t.TotalQty).HasColumnName("TotalQty");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.TotalMoney).HasColumnName("TotalMoney");
            this.Property(t => t.preferencemoney).HasColumnName("preferencemoney");
            this.Property(t => t.premoney).HasColumnName("premoney");
            this.Property(t => t.Totalinmoney).HasColumnName("Totalinmoney");
            this.Property(t => t.CashMoney).HasColumnName("CashMoney");
            this.Property(t => t.ChangeMoney).HasColumnName("ChangeMoney");
            this.Property(t => t.BackBillnumberID).HasColumnName("BackBillnumberID");
            this.Property(t => t.UpLoadBillnumberID).HasColumnName("UpLoadBillnumberID");
            this.Property(t => t.PromoRuleId).HasColumnName("PromoRuleId");
            this.Property(t => t.PromotionMsg).HasColumnName("PromotionMsg");
            this.Property(t => t.BuyBackType).HasColumnName("BuyBackType");
            this.Property(t => t.billtime).HasColumnName("billtime");
        }
    }
}
