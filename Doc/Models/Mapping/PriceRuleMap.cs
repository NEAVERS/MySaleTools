using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PriceRuleMap : EntityTypeConfiguration<PriceRule>
    {
        public PriceRuleMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.UserCode, t.FullName, t.PriceBillIndexID, t.PosDataVersion });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.UserCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.PriceBillIndexID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.StartTime)
                .HasMaxLength(10);

            this.Property(t => t.EndTime)
                .HasMaxLength(10);

            this.Property(t => t.PriceDay)
                .HasMaxLength(7);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            this.Property(t => t.Checke)
                .HasMaxLength(50);

            this.Property(t => t.Checker)
                .HasMaxLength(50);

            this.Property(t => t.DeletedR)
                .HasMaxLength(50);

            this.Property(t => t.PosDataVersion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("PriceRule");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.PriceBillIndexID).HasColumnName("PriceBillIndexID");
            this.Property(t => t.VipConfig).HasColumnName("VipConfig");
            this.Property(t => t.StoresConfig).HasColumnName("StoresConfig");
            this.Property(t => t.KConfig).HasColumnName("KConfig");
            this.Property(t => t.DConfig).HasColumnName("DConfig");
            this.Property(t => t.EConfig).HasColumnName("EConfig");
            this.Property(t => t.BConfig).HasColumnName("BConfig");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.PriceDay).HasColumnName("PriceDay");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Checke).HasColumnName("Checke");
            this.Property(t => t.Checker).HasColumnName("Checker");
            this.Property(t => t.VaildDate).HasColumnName("VaildDate");
            this.Property(t => t.DeletedR).HasColumnName("DeletedR");
            this.Property(t => t.DeletedDate).HasColumnName("DeletedDate");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.XiWaMaxNumber).HasColumnName("XiWaMaxNumber");
            this.Property(t => t.PosDataVersion).HasColumnName("PosDataVersion");
            this.Property(t => t.VipEnable).HasColumnName("VipEnable");
            this.Property(t => t.BtypeEnable).HasColumnName("BtypeEnable");
            this.Property(t => t.VBEnable).HasColumnName("VBEnable");
        }
    }
}
