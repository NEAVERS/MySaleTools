using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class wx_Bill_SendMap : EntityTypeConfiguration<wx_Bill_Send>
    {
        public wx_Bill_SendMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberID, t.PTypeID, t.IsUnit2, t.ID });

            // Properties
            this.Property(t => t.BillNumberID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IsUnit2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment)
                .HasMaxLength(255);

            this.Property(t => t.JieJianPTypeID)
                .HasMaxLength(50);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            this.Property(t => t.GoodsNumber)
                .HasMaxLength(100);

            this.Property(t => t.Errdes1)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("wx_Bill_Send");
            this.Property(t => t.BillNumberID).HasColumnName("BillNumberID");
            this.Property(t => t.PTypeID).HasColumnName("PTypeID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.IsUnit2).HasColumnName("IsUnit2");
            this.Property(t => t.SendBackQty).HasColumnName("SendBackQty");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Serial).HasColumnName("Serial");
            this.Property(t => t.JieJianBillNumberID).HasColumnName("JieJianBillNumberID");
            this.Property(t => t.JieJianID).HasColumnName("JieJianID");
            this.Property(t => t.JieJianPTypeID).HasColumnName("JieJianPTypeID");
            this.Property(t => t.JieJianState).HasColumnName("JieJianState");
            this.Property(t => t.OutFactoryDate).HasColumnName("OutFactoryDate");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.IsCombined).HasColumnName("IsCombined");
            this.Property(t => t.GoodsNumber).HasColumnName("GoodsNumber");
            this.Property(t => t.CargoID).HasColumnName("CargoID");
            this.Property(t => t.NQty).HasColumnName("NQty");
            this.Property(t => t.UnitRate).HasColumnName("UnitRate");
            this.Property(t => t.ShowOrder).HasColumnName("ShowOrder");
            this.Property(t => t.Errdes1).HasColumnName("Errdes1");
        }
    }
}
