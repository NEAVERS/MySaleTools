using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Offline_BillMap : EntityTypeConfiguration<Offline_Bill>
    {
        public Offline_BillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OFF_ID, t.BillNumberId, t.Checked, t.TASKID, t.IsUnit2 });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            this.Property(t => t.AtypeId)
                .HasMaxLength(50);

            this.Property(t => t.PtypeId)
                .HasMaxLength(50);

            this.Property(t => t.BtypeId)
                .HasMaxLength(50);

            this.Property(t => t.JobNumber)
                .HasMaxLength(20);

            this.Property(t => t.inorout)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.TASKID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsUnit2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Offline_Bill");
            this.Property(t => t.OFF_ID).HasColumnName("OFF_ID");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.AtypeId).HasColumnName("AtypeId");
            this.Property(t => t.PtypeId).HasColumnName("PtypeId");
            this.Property(t => t.BtypeId).HasColumnName("BtypeId");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.ReachQty).HasColumnName("ReachQty");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.SalePrice).HasColumnName("SalePrice");
            this.Property(t => t.TaxPrice).HasColumnName("TaxPrice");
            this.Property(t => t.TaxTotal).HasColumnName("TaxTotal");
            this.Property(t => t.total).HasColumnName("total");
            this.Property(t => t.totalinmoney).HasColumnName("totalinmoney");
            this.Property(t => t.discount).HasColumnName("discount");
            this.Property(t => t.DiscountPrice).HasColumnName("DiscountPrice");
            this.Property(t => t.costprice).HasColumnName("costprice");
            this.Property(t => t.JobNumber).HasColumnName("JobNumber");
            this.Property(t => t.GoodsNo).HasColumnName("GoodsNo");
            this.Property(t => t.inorout).HasColumnName("inorout");
            this.Property(t => t.OutFactoryDate).HasColumnName("OutFactoryDate");
            this.Property(t => t.Checked).HasColumnName("Checked");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TeamNo).HasColumnName("TeamNo");
            this.Property(t => t.TeamNO1).HasColumnName("TeamNO1");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.TASKID).HasColumnName("TASKID");
            this.Property(t => t.OFFLINE_ID).HasColumnName("OFFLINE_ID");
            this.Property(t => t.IsUnit2).HasColumnName("IsUnit2");
        }
    }
}
