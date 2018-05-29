using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class vWeb_OrderBillIndex_NewMap : EntityTypeConfiguration<vWeb_OrderBillIndex_New>
    {
        public vWeb_OrderBillIndex_NewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.billNumberId, t.BillDate, t.Billcode, t.EName1, t.KName, t.DName, t.billtype, t.EName2, t.OrderState });

            // Properties
            this.Property(t => t.billNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BName)
                .HasMaxLength(66);

            this.Property(t => t.Billcode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.comment)
                .HasMaxLength(256);

            this.Property(t => t.EName1)
                .IsRequired()
                .HasMaxLength(66);

            this.Property(t => t.PostCode)
                .HasMaxLength(200);

            this.Property(t => t.TelAndAddress)
                .HasMaxLength(256);

            this.Property(t => t.WayMode)
                .HasMaxLength(50);

            this.Property(t => t.BillStatus)
                .HasMaxLength(8);

            this.Property(t => t.KName)
                .IsRequired()
                .HasMaxLength(66);

            this.Property(t => t.btypeid)
                .HasMaxLength(50);

            this.Property(t => t.etypeid)
                .HasMaxLength(50);

            this.Property(t => t.ktypeid)
                .HasMaxLength(50);

            this.Property(t => t.busercode)
                .HasMaxLength(26);

            this.Property(t => t.eusercode)
                .HasMaxLength(26);

            this.Property(t => t.kusercode)
                .HasMaxLength(26);

            this.Property(t => t.dusercode)
                .HasMaxLength(100);

            this.Property(t => t.DName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.billtype)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EName2)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.explain)
                .HasMaxLength(256);

            this.Property(t => t.WayBillCode)
                .HasMaxLength(50);

            this.Property(t => t.GoodsNumber)
                .HasMaxLength(20);

            this.Property(t => t.PackWay)
                .HasMaxLength(20);

            this.Property(t => t.TEL)
                .HasMaxLength(100);

            this.Property(t => t.OrderState)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("vWeb_OrderBillIndex_New");
            this.Property(t => t.billNumberId).HasColumnName("billNumberId");
            this.Property(t => t.BName).HasColumnName("BName");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.Billcode).HasColumnName("Billcode");
            this.Property(t => t.totalmoney).HasColumnName("totalmoney");
            this.Property(t => t.totalqty).HasColumnName("totalqty");
            this.Property(t => t.comment).HasColumnName("comment");
            this.Property(t => t.IfAudit).HasColumnName("IfAudit");
            this.Property(t => t.EName1).HasColumnName("EName1");
            this.Property(t => t.PostCode).HasColumnName("PostCode");
            this.Property(t => t.TelAndAddress).HasColumnName("TelAndAddress");
            this.Property(t => t.ReachDate).HasColumnName("ReachDate");
            this.Property(t => t.WayMode).HasColumnName("WayMode");
            this.Property(t => t.BillStatus).HasColumnName("BillStatus");
            this.Property(t => t.KName).HasColumnName("KName");
            this.Property(t => t.btypeid).HasColumnName("btypeid");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.ktypeid).HasColumnName("ktypeid");
            this.Property(t => t.busercode).HasColumnName("busercode");
            this.Property(t => t.eusercode).HasColumnName("eusercode");
            this.Property(t => t.kusercode).HasColumnName("kusercode");
            this.Property(t => t.dusercode).HasColumnName("dusercode");
            this.Property(t => t.DName).HasColumnName("DName");
            this.Property(t => t.billtype).HasColumnName("billtype");
            this.Property(t => t.EName2).HasColumnName("EName2");
            this.Property(t => t.explain).HasColumnName("explain");
            this.Property(t => t.WayBillCode).HasColumnName("WayBillCode");
            this.Property(t => t.GoodsNumber).HasColumnName("GoodsNumber");
            this.Property(t => t.PackWay).HasColumnName("PackWay");
            this.Property(t => t.TEL).HasColumnName("TEL");
            this.Property(t => t.IsFinished).HasColumnName("IsFinished");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.ReachQty).HasColumnName("ReachQty");
            this.Property(t => t.OrderState).HasColumnName("OrderState");
            this.Property(t => t.ARLimitTime).HasColumnName("ARLimitTime");
        }
    }
}
