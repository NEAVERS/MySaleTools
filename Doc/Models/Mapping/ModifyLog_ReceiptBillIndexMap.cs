using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class ModifyLog_ReceiptBillIndexMap : EntityTypeConfiguration<ModifyLog_ReceiptBillIndex>
    {
        public ModifyLog_ReceiptBillIndexMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberID, t.BillDate, t.BillCode, t.BillType, t.RedWord, t.ifcheck, t.IfStopMoney, t.Draft });

            // Properties
            this.Property(t => t.BillNumberID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BillCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.BillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FaPiaoType)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.FaPiaoCode)
                .HasMaxLength(256);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            this.Property(t => t.Explain)
                .HasMaxLength(256);

            this.Property(t => t.BTypeID)
                .HasMaxLength(100);

            this.Property(t => t.ETypeID)
                .HasMaxLength(100);

            this.Property(t => t.DTypeID)
                .HasMaxLength(100);

            this.Property(t => t.checke)
                .HasMaxLength(100);

            this.Property(t => t.Assessor)
                .HasMaxLength(50);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            this.Property(t => t.DealBTypeID)
                .HasMaxLength(50);

            this.Property(t => t.RedWord)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ifcheck)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.IfStopMoney)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.JSState)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.JSStyle)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Poster)
                .HasMaxLength(100);

            this.Property(t => t.UpdateE)
                .HasMaxLength(100);

            this.Property(t => t.IfAudit)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ATypeID1)
                .HasMaxLength(50);

            this.Property(t => t.ATypeID2)
                .HasMaxLength(50);

            this.Property(t => t.RedReason)
                .HasMaxLength(500);

            this.Property(t => t.Reconciliation)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.TallyId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ModifyLog_ReceiptBillIndex");
            this.Property(t => t.BillNumberID).HasColumnName("BillNumberID");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.FaPiaoType).HasColumnName("FaPiaoType");
            this.Property(t => t.FaPiaoCode).HasColumnName("FaPiaoCode");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Explain).HasColumnName("Explain");
            this.Property(t => t.BTypeID).HasColumnName("BTypeID");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
            this.Property(t => t.DTypeID).HasColumnName("DTypeID");
            this.Property(t => t.checke).HasColumnName("checke");
            this.Property(t => t.Assessor).HasColumnName("Assessor");
            this.Property(t => t.Tax).HasColumnName("Tax");
            this.Property(t => t.TotalQty).HasColumnName("TotalQty");
            this.Property(t => t.TotalMoney).HasColumnName("TotalMoney");
            this.Property(t => t.TaxTotalMoney).HasColumnName("TaxTotalMoney");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.OtherTotal).HasColumnName("OtherTotal");
            this.Property(t => t.ifYearBill).HasColumnName("ifYearBill");
            this.Property(t => t.IsIni).HasColumnName("IsIni");
            this.Property(t => t.CID).HasColumnName("CID");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.NTotalMoney).HasColumnName("NTotalMoney");
            this.Property(t => t.NTaxTotalMoney).HasColumnName("NTaxTotalMoney");
            this.Property(t => t.DealBTypeID).HasColumnName("DealBTypeID");
            this.Property(t => t.TaskType).HasColumnName("TaskType");
            this.Property(t => t.AlertDay).HasColumnName("AlertDay");
            this.Property(t => t.RedWord).HasColumnName("RedWord");
            this.Property(t => t.ifcheck).HasColumnName("ifcheck");
            this.Property(t => t.IfStopMoney).HasColumnName("IfStopMoney");
            this.Property(t => t.CompleteTotal).HasColumnName("CompleteTotal");
            this.Property(t => t.NCompleteTotal).HasColumnName("NCompleteTotal");
            this.Property(t => t.Draft).HasColumnName("Draft");
            this.Property(t => t.JSState).HasColumnName("JSState");
            this.Property(t => t.JSStyle).HasColumnName("JSStyle");
            this.Property(t => t.Poster).HasColumnName("Poster");
            this.Property(t => t.LastUpdateTime).HasColumnName("LastUpdateTime");
            this.Property(t => t.checkTime).HasColumnName("checkTime");
            this.Property(t => t.Posttime).HasColumnName("Posttime");
            this.Property(t => t.UpdateE).HasColumnName("UpdateE");
            this.Property(t => t.IfAudit).HasColumnName("IfAudit");
            this.Property(t => t.ATypeID1).HasColumnName("ATypeID1");
            this.Property(t => t.ATypeID2).HasColumnName("ATypeID2");
            this.Property(t => t.Period).HasColumnName("Period");
            this.Property(t => t.RedReason).HasColumnName("RedReason");
            this.Property(t => t.ATID).HasColumnName("ATID");
            this.Property(t => t.Reconciliation).HasColumnName("Reconciliation");
            this.Property(t => t.TeamNo).HasColumnName("TeamNo");
            this.Property(t => t.TallyId).HasColumnName("TallyId");
            this.Property(t => t.ChargeOffTotal).HasColumnName("ChargeOffTotal");
            this.Property(t => t.NChargeOffTotal).HasColumnName("NChargeOffTotal");
            this.Property(t => t.ModifyTime).HasColumnName("ModifyTime");
            this.Property(t => t.ModifyCount).HasColumnName("ModifyCount");
        }
    }
}
