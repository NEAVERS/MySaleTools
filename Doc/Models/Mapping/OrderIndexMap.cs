using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OrderIndexMap : EntityTypeConfiguration<OrderIndex>
    {
        public OrderIndexMap()
        {
            // Primary Key
            this.HasKey(t => new { t.billNumberId, t.BillDate, t.Billcode, t.billtype, t.period, t.checked, t.redWord, t.BillOver, t.BillStatus, t.OrderState, t.PrePriceNum });

            // Properties
            this.Property(t => t.billNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.btypeid)
                .HasMaxLength(50);

            this.Property(t => t.etypeid)
                .HasMaxLength(50);

            this.Property(t => t.ktypeid)
                .HasMaxLength(50);

            this.Property(t => t.Billcode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.billtype)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.period)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.comment)
                .HasMaxLength(256);

            this.Property(t => t.explain)
                .HasMaxLength(256);

            this.Property(t => t.Checke)
                .HasMaxLength(50);

            this.Property(t => t.BillStatus)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.etypeid2)
                .HasMaxLength(50);

            this.Property(t => t.WayMode)
                .HasMaxLength(50);

            this.Property(t => t.WayBillCode)
                .HasMaxLength(50);

            this.Property(t => t.GoodsNumber)
                .HasMaxLength(20);

            this.Property(t => t.PackWay)
                .HasMaxLength(20);

            this.Property(t => t.TEL)
                .HasMaxLength(100);

            this.Property(t => t.DtypeId)
                .HasMaxLength(50);

            this.Property(t => t.CanAlert)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.DelayType)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.DelayValue)
                .HasMaxLength(50);

            this.Property(t => t.OrderState)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            this.Property(t => t.PrePriceNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.YapiOrderID)
                .HasMaxLength(20);

            this.Property(t => t.DealBTypeID)
                .HasMaxLength(50);

            this.Property(t => t.atypeID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OrderIndex");
            this.Property(t => t.billNumberId).HasColumnName("billNumberId");
            this.Property(t => t.btypeid).HasColumnName("btypeid");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.ktypeid).HasColumnName("ktypeid");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.ReachDate).HasColumnName("ReachDate");
            this.Property(t => t.Billcode).HasColumnName("Billcode");
            this.Property(t => t.billtype).HasColumnName("billtype");
            this.Property(t => t.totalmoney).HasColumnName("totalmoney");
            this.Property(t => t.totalqty).HasColumnName("totalqty");
            this.Property(t => t.period).HasColumnName("period");
            this.Property(t => t.checked).HasColumnName("checked");
            this.Property(t => t.redWord).HasColumnName("redWord");
            this.Property(t => t.BillOver).HasColumnName("BillOver");
            this.Property(t => t.comment).HasColumnName("comment");
            this.Property(t => t.explain).HasColumnName("explain");
            this.Property(t => t.Checke).HasColumnName("Checke");
            this.Property(t => t.Tax).HasColumnName("Tax");
            this.Property(t => t.BillStatus).HasColumnName("BillStatus");
            this.Property(t => t.etypeid2).HasColumnName("etypeid2");
            this.Property(t => t.WayMode).HasColumnName("WayMode");
            this.Property(t => t.WayBillCode).HasColumnName("WayBillCode");
            this.Property(t => t.GoodsNumber).HasColumnName("GoodsNumber");
            this.Property(t => t.PackWay).HasColumnName("PackWay");
            this.Property(t => t.TEL).HasColumnName("TEL");
            this.Property(t => t.IfAudit).HasColumnName("IfAudit");
            this.Property(t => t.DtypeId).HasColumnName("DtypeId");
            this.Property(t => t.IsFinished).HasColumnName("IsFinished");
            this.Property(t => t.CanAlert).HasColumnName("CanAlert");
            this.Property(t => t.DelayType).HasColumnName("DelayType");
            this.Property(t => t.DelayValue).HasColumnName("DelayValue");
            this.Property(t => t.OrderState).HasColumnName("OrderState");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.FromBillNumberID).HasColumnName("FromBillNumberID");
            this.Property(t => t.CustomerTotal).HasColumnName("CustomerTotal");
            this.Property(t => t.IsIni).HasColumnName("IsIni");
            this.Property(t => t.Ntotalmoney).HasColumnName("Ntotalmoney");
            this.Property(t => t.CID).HasColumnName("CID");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.billproperty).HasColumnName("billproperty");
            this.Property(t => t.PrePriceNum).HasColumnName("PrePriceNum");
            this.Property(t => t.IsYapi).HasColumnName("IsYapi");
            this.Property(t => t.YapiOrderID).HasColumnName("YapiOrderID");
            this.Property(t => t.NCustomerTotal).HasColumnName("NCustomerTotal");
            this.Property(t => t.DealBTypeID).HasColumnName("DealBTypeID");
            this.Property(t => t.atypeID).HasColumnName("atypeID");
            this.Property(t => t.totalinmoney).HasColumnName("totalinmoney");
            this.Property(t => t.ntotalinmoney).HasColumnName("ntotalinmoney");
            this.Property(t => t.checkTime).HasColumnName("checkTime");
            this.Property(t => t.Discount).HasColumnName("Discount");
        }
    }
}
