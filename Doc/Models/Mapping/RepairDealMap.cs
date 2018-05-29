using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class RepairDealMap : EntityTypeConfiguration<RepairDeal>
    {
        public RepairDealMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberID, t.ID });

            // Properties
            this.Property(t => t.BillNumberID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BillCode)
                .HasMaxLength(200);

            this.Property(t => t.PTypeID)
                .HasMaxLength(50);

            this.Property(t => t.ETypeID)
                .HasMaxLength(50);

            this.Property(t => t.IfCheck)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.Checke)
                .HasMaxLength(50);

            this.Property(t => t.Fault)
                .HasMaxLength(8000);

            this.Property(t => t.Comment)
                .HasMaxLength(8000);

            this.Property(t => t.KTypeID1)
                .HasMaxLength(50);

            this.Property(t => t.KTypeID2)
                .HasMaxLength(50);

            this.Property(t => t.BTypeID)
                .HasMaxLength(50);

            this.Property(t => t.ATypeID)
                .HasMaxLength(50);

            this.Property(t => t.Brief)
                .HasMaxLength(200);

            this.Property(t => t.FreeMemo)
                .HasMaxLength(200);

            this.Property(t => t.ETypeID1)
                .HasMaxLength(50);

            this.Property(t => t.ETypeID2)
                .HasMaxLength(50);

            this.Property(t => t.IDCard)
                .HasMaxLength(30);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("RepairDeal");
            this.Property(t => t.BillNumberID).HasColumnName("BillNumberID");
            this.Property(t => t.EngageBillID).HasColumnName("EngageBillID");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.PTypeID).HasColumnName("PTypeID");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
            this.Property(t => t.IfCheck).HasColumnName("IfCheck");
            this.Property(t => t.Checke).HasColumnName("Checke");
            this.Property(t => t.RedWord).HasColumnName("RedWord");
            this.Property(t => t.Draft).HasColumnName("Draft");
            this.Property(t => t.Stat).HasColumnName("Stat");
            this.Property(t => t.Fault).HasColumnName("Fault");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Method).HasColumnName("Method");
            this.Property(t => t.KTypeID1).HasColumnName("KTypeID1");
            this.Property(t => t.KTypeID2).HasColumnName("KTypeID2");
            this.Property(t => t.MoneyChange).HasColumnName("MoneyChange");
            this.Property(t => t.MoneyRepair).HasColumnName("MoneyRepair");
            this.Property(t => t.TotalMoney).HasColumnName("TotalMoney");
            this.Property(t => t.TotalInMoney).HasColumnName("TotalInMoney");
            this.Property(t => t.BTypeID).HasColumnName("BTypeID");
            this.Property(t => t.ATypeID).HasColumnName("ATypeID");
            this.Property(t => t.Brief).HasColumnName("Brief");
            this.Property(t => t.NotFree).HasColumnName("NotFree");
            this.Property(t => t.FreeMemo).HasColumnName("FreeMemo");
            this.Property(t => t.ETypeID1).HasColumnName("ETypeID1");
            this.Property(t => t.ETypeID2).HasColumnName("ETypeID2");
            this.Property(t => t.PayDate).HasColumnName("PayDate");
            this.Property(t => t.IfPay).HasColumnName("IfPay");
            this.Property(t => t.IDCard).HasColumnName("IDCard");
            this.Property(t => t.TeamNo).HasColumnName("TeamNo");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
