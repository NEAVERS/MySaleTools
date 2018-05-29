using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Offline_BillIndexMap : EntityTypeConfiguration<Offline_BillIndex>
    {
        public Offline_BillIndexMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OFF_ID, t.BillNumberId, t.BillDate, t.BillCode, t.BillType, t.RedWord, t.draft, t.TaskID, t.Import });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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

            this.Property(t => t.StockName)
                .HasMaxLength(66);

            this.Property(t => t.TaskID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Import)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.STOCKID)
                .HasMaxLength(50);

            this.Property(t => t.Assessor)
                .HasMaxLength(50);

            this.Property(t => t.IfAudit)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Audit_explain)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("Offline_BillIndex");
            this.Property(t => t.OFF_ID).HasColumnName("OFF_ID");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.atypeid).HasColumnName("atypeid");
            this.Property(t => t.ptypeid).HasColumnName("ptypeid");
            this.Property(t => t.btypeid).HasColumnName("btypeid");
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
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.StockName).HasColumnName("StockName");
            this.Property(t => t.TaskID).HasColumnName("TaskID");
            this.Property(t => t.Import).HasColumnName("Import");
            this.Property(t => t.STOCKID).HasColumnName("STOCKID");
            this.Property(t => t.AlertDay).HasColumnName("AlertDay");
            this.Property(t => t.CompleteTotal).HasColumnName("CompleteTotal");
            this.Property(t => t.Assessor).HasColumnName("Assessor");
            this.Property(t => t.IfAudit).HasColumnName("IfAudit");
            this.Property(t => t.Audit_explain).HasColumnName("Audit_explain");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
