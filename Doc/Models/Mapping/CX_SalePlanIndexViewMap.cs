using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CX_SalePlanIndexViewMap : EntityTypeConfiguration<CX_SalePlanIndexView>
    {
        public CX_SalePlanIndexViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.BillType, t.BillName, t.BillCode, t.BillDateTime, t.StartDate, t.EndDate, t.EtypeId, t.BillStatus, t.BreakStatus, t.DateTimeType, t.StartTime, t.EndTime });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.BillType)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.BillName)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.BillCode)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.EtypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JTypeID)
                .HasMaxLength(50);

            this.Property(t => t.BillStatus)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.BreakStatus)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.DateTimeType)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.MonthDay)
                .HasMaxLength(2);

            this.Property(t => t.MonthWeek)
                .HasMaxLength(1);

            this.Property(t => t.MonthWeekDay)
                .HasMaxLength(1);

            this.Property(t => t.WeekDays)
                .HasMaxLength(7);

            this.Property(t => t.StartTime)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.EndTime)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.SalePrice)
                .HasMaxLength(25);

            this.Property(t => t.SaleType)
                .HasMaxLength(1);

            this.Property(t => t.TotalMoney)
                .HasMaxLength(18);

            this.Property(t => t.Remark)
                .HasMaxLength(100);

            this.Property(t => t.Checke)
                .HasMaxLength(50);

            this.Property(t => t.Breake)
                .HasMaxLength(50);

            this.Property(t => t.CheckeDateTime)
                .HasMaxLength(20);

            this.Property(t => t.BreakeDateTime)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("CX_SalePlanIndexView");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.BillName).HasColumnName("BillName");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.BillDateTime).HasColumnName("BillDateTime");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.EtypeId).HasColumnName("EtypeId");
            this.Property(t => t.JTypeID).HasColumnName("JTypeID");
            this.Property(t => t.BillStatus).HasColumnName("BillStatus");
            this.Property(t => t.BreakStatus).HasColumnName("BreakStatus");
            this.Property(t => t.DateTimeType).HasColumnName("DateTimeType");
            this.Property(t => t.MonthDay).HasColumnName("MonthDay");
            this.Property(t => t.MonthWeek).HasColumnName("MonthWeek");
            this.Property(t => t.MonthWeekDay).HasColumnName("MonthWeekDay");
            this.Property(t => t.WeekDays).HasColumnName("WeekDays");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.SalePrice).HasColumnName("SalePrice");
            this.Property(t => t.SaleType).HasColumnName("SaleType");
            this.Property(t => t.TotalMoney).HasColumnName("TotalMoney");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.Checke).HasColumnName("Checke");
            this.Property(t => t.Breake).HasColumnName("Breake");
            this.Property(t => t.CheckeDateTime).HasColumnName("CheckeDateTime");
            this.Property(t => t.BreakeDateTime).HasColumnName("BreakeDateTime");
        }
    }
}
