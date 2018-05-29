using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class wx_Bill_CallMap : EntityTypeConfiguration<wx_Bill_Call>
    {
        public wx_Bill_CallMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.PTypeID, t.IsUnit2, t.BaoXiu, t.ID });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IsUnit2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Serial)
                .HasMaxLength(200);

            this.Property(t => t.BuyDate)
                .HasMaxLength(50);

            this.Property(t => t.ErrDes)
                .HasMaxLength(3000);

            this.Property(t => t.ErrDeal)
                .HasMaxLength(3000);

            this.Property(t => t.ETypeID)
                .HasMaxLength(50);

            this.Property(t => t.BaoXiu)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment)
                .HasMaxLength(255);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            this.Property(t => t.GoodsNumber)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("wx_Bill_Call");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.PTypeID).HasColumnName("PTypeID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.IsUnit2).HasColumnName("IsUnit2");
            this.Property(t => t.Serial).HasColumnName("Serial");
            this.Property(t => t.BuyDate).HasColumnName("BuyDate");
            this.Property(t => t.ErrDes).HasColumnName("ErrDes");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.ErrDeal).HasColumnName("ErrDeal");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
            this.Property(t => t.BaoXiu).HasColumnName("BaoXiu");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.OutFactoryDate).HasColumnName("OutFactoryDate");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.ifYearBillDisplay).HasColumnName("ifYearBillDisplay");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.IsCombined).HasColumnName("IsCombined");
            this.Property(t => t.GoodsNumber).HasColumnName("GoodsNumber");
            this.Property(t => t.CargoID).HasColumnName("CargoID");
            this.Property(t => t.NQty).HasColumnName("NQty");
            this.Property(t => t.UnitRate).HasColumnName("UnitRate");
            this.Property(t => t.ShowOrder).HasColumnName("ShowOrder");
        }
    }
}
