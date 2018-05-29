using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class LendIndexMap : EntityTypeConfiguration<LendIndex>
    {
        public LendIndexMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.BillDate, t.BillCode, t.BillType, t.draft, t.Uploaded, t.ID });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.BillCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.BillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            this.Property(t => t.atypeid)
                .HasMaxLength(50);

            this.Property(t => t.ptypeid)
                .HasMaxLength(50);

            this.Property(t => t.btypeid)
                .HasMaxLength(50);

            this.Property(t => t.dealbtypeid)
                .HasMaxLength(50);

            this.Property(t => t.etypeid)
                .HasMaxLength(50);

            this.Property(t => t.ktypeid)
                .HasMaxLength(50);

            this.Property(t => t.ktypeid2)
                .HasMaxLength(50);

            this.Property(t => t.ifcheck)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.checke)
                .HasMaxLength(50);

            this.Property(t => t.explain)
                .HasMaxLength(256);

            this.Property(t => t.waybillcode)
                .HasMaxLength(50);

            this.Property(t => t.packway)
                .HasMaxLength(20);

            this.Property(t => t.TEL)
                .HasMaxLength(60);

            this.Property(t => t.DTypeID)
                .HasMaxLength(50);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IfAudit)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            this.Property(t => t.redreason)
                .HasMaxLength(500);

            this.Property(t => t.Poster)
                .HasMaxLength(50);

            this.Property(t => t.UpdateE)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("LendIndex");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.atypeid).HasColumnName("atypeid");
            this.Property(t => t.ptypeid).HasColumnName("ptypeid");
            this.Property(t => t.btypeid).HasColumnName("btypeid");
            this.Property(t => t.dealbtypeid).HasColumnName("dealbtypeid");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.ktypeid).HasColumnName("ktypeid");
            this.Property(t => t.ktypeid2).HasColumnName("ktypeid2");
            this.Property(t => t.ifcheck).HasColumnName("ifcheck");
            this.Property(t => t.checke).HasColumnName("checke");
            this.Property(t => t.totalmoney).HasColumnName("totalmoney");
            this.Property(t => t.totalinmoney).HasColumnName("totalinmoney");
            this.Property(t => t.totalqty).HasColumnName("totalqty");
            this.Property(t => t.tax).HasColumnName("tax");
            this.Property(t => t.period).HasColumnName("period");
            this.Property(t => t.explain).HasColumnName("explain");
            this.Property(t => t.RedWord).HasColumnName("RedWord");
            this.Property(t => t.draft).HasColumnName("draft");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.waybillcode).HasColumnName("waybillcode");
            this.Property(t => t.goodsnumber).HasColumnName("goodsnumber");
            this.Property(t => t.packway).HasColumnName("packway");
            this.Property(t => t.TEL).HasColumnName("TEL");
            this.Property(t => t.Uploaded).HasColumnName("Uploaded");
            this.Property(t => t.OFF_ID).HasColumnName("OFF_ID");
            this.Property(t => t.DTypeID).HasColumnName("DTypeID");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.IfAudit).HasColumnName("IfAudit");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.IsIni).HasColumnName("IsIni");
            this.Property(t => t.redreason).HasColumnName("redreason");
            this.Property(t => t.Poster).HasColumnName("Poster");
            this.Property(t => t.posttime).HasColumnName("posttime");
            this.Property(t => t.checkTime).HasColumnName("checkTime");
            this.Property(t => t.ifYearBill).HasColumnName("ifYearBill");
            this.Property(t => t.UpdateE).HasColumnName("UpdateE");
        }
    }
}
