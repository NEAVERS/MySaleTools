using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class QP_RepairItemsMap : EntityTypeConfiguration<QP_RepairItems>
    {
        public QP_RepairItemsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.TypeID, t.ParID, t.Leveal, t.SonCount, t.SonNum, t.UserCode, t.FullName });

            // Properties
            this.Property(t => t.TypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ParID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Leveal)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SonCount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SonNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ItemType)
                .HasMaxLength(200);

            this.Property(t => t.RepairAutoTypeID)
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(500);

            this.Property(t => t.UserDefine1)
                .HasMaxLength(250);

            this.Property(t => t.UserDefine2)
                .HasMaxLength(250);

            this.Property(t => t.UserDefine3)
                .HasMaxLength(250);

            this.Property(t => t.UserDefine4)
                .HasMaxLength(250);

            this.Property(t => t.UserDefine5)
                .HasMaxLength(250);

            this.Property(t => t.PyCode)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("QP_RepairItems");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.ParID).HasColumnName("ParID");
            this.Property(t => t.Leveal).HasColumnName("Leveal");
            this.Property(t => t.SonCount).HasColumnName("SonCount");
            this.Property(t => t.SonNum).HasColumnName("SonNum");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.ItemType).HasColumnName("ItemType");
            this.Property(t => t.StandardManHour).HasColumnName("StandardManHour");
            this.Property(t => t.CheckHour).HasColumnName("CheckHour");
            this.Property(t => t.StandardPrice).HasColumnName("StandardPrice");
            this.Property(t => t.TopPrice).HasColumnName("TopPrice");
            this.Property(t => t.LowPrice).HasColumnName("LowPrice");
            this.Property(t => t.ChargeMode).HasColumnName("ChargeMode");
            this.Property(t => t.RepairAutoTypeID).HasColumnName("RepairAutoTypeID");
            this.Property(t => t.MaintainDays).HasColumnName("MaintainDays");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.XiWaMaxNumber).HasColumnName("XiWaMaxNumber");
            this.Property(t => t.MaintainMileage).HasColumnName("MaintainMileage");
            this.Property(t => t.UserDefine1).HasColumnName("UserDefine1");
            this.Property(t => t.UserDefine2).HasColumnName("UserDefine2");
            this.Property(t => t.UserDefine3).HasColumnName("UserDefine3");
            this.Property(t => t.UserDefine4).HasColumnName("UserDefine4");
            this.Property(t => t.UserDefine5).HasColumnName("UserDefine5");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
        }
    }
}
