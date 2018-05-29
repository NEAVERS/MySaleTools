using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PromoRuleMap : EntityTypeConfiguration<PromoRule>
    {
        public PromoRuleMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.PosDataVersion, t.BtypeConfig });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.BillCode)
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .HasMaxLength(200);

            this.Property(t => t.Checke)
                .HasMaxLength(50);

            this.Property(t => t.Checker)
                .HasMaxLength(50);

            this.Property(t => t.DeletedR)
                .HasMaxLength(50);

            this.Property(t => t.StartTime)
                .HasMaxLength(10);

            this.Property(t => t.EndTime)
                .HasMaxLength(10);

            this.Property(t => t.PriceDay)
                .HasMaxLength(7);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            this.Property(t => t.PosDataVersion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            this.Property(t => t.BtypeConfig)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PromoRule");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.PromoStylePtype).HasColumnName("PromoStylePtype");
            this.Property(t => t.PromoStyleDiscount).HasColumnName("PromoStyleDiscount");
            this.Property(t => t.VIPConfig).HasColumnName("VIPConfig");
            this.Property(t => t.KConfig).HasColumnName("KConfig");
            this.Property(t => t.EConfig).HasColumnName("EConfig");
            this.Property(t => t.PConfig).HasColumnName("PConfig");
            this.Property(t => t.CalculateStyle).HasColumnName("CalculateStyle");
            this.Property(t => t.BindType).HasColumnName("BindType");
            this.Property(t => t.ReachCondition).HasColumnName("ReachCondition");
            this.Property(t => t.AccumulatedProfits).HasColumnName("AccumulatedProfits");
            this.Property(t => t.DoubleDiscount).HasColumnName("DoubleDiscount");
            this.Property(t => t.BillState).HasColumnName("BillState");
            this.Property(t => t.Checke).HasColumnName("Checke");
            this.Property(t => t.Checker).HasColumnName("Checker");
            this.Property(t => t.VaildDate).HasColumnName("VaildDate");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.DeletedR).HasColumnName("DeletedR");
            this.Property(t => t.DeletedDate).HasColumnName("DeletedDate");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.PriceDay).HasColumnName("PriceDay");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.GiftsType).HasColumnName("GiftsType");
            this.Property(t => t.XiWaMaxNumber).HasColumnName("XiWaMaxNumber");
            this.Property(t => t.PosDataVersion).HasColumnName("PosDataVersion");
            this.Property(t => t.BtypeConfig).HasColumnName("BtypeConfig");
        }
    }
}
