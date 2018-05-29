using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class QP_RepairAutoInfoMap : EntityTypeConfiguration<QP_RepairAutoInfo>
    {
        public QP_RepairAutoInfoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.TypeID, t.ParID, t.Leveal, t.SonCount, t.SonNum, t.PlateNumber, t.BTypeID, t.RepairAutoTypeID, t.ChargingStandardsID });

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

            this.Property(t => t.PlateNumber)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.EngineNumber)
                .HasMaxLength(200);

            this.Property(t => t.BTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RepairAutoTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FrameNumber)
                .HasMaxLength(200);

            this.Property(t => t.TransmissionNumber)
                .HasMaxLength(200);

            this.Property(t => t.VIN)
                .HasMaxLength(200);

            this.Property(t => t.Color)
                .HasMaxLength(100);

            this.Property(t => t.ForceMaintainMileage)
                .HasMaxLength(100);

            this.Property(t => t.FirstMaintainMileage)
                .HasMaxLength(100);

            this.Property(t => t.Comment)
                .HasMaxLength(300);

            this.Property(t => t.LeaveFactoryNum)
                .HasMaxLength(100);

            this.Property(t => t.Driver)
                .HasMaxLength(100);

            this.Property(t => t.DriverMobilePhone)
                .HasMaxLength(100);

            this.Property(t => t.CardNumber)
                .HasMaxLength(100);

            this.Property(t => t.ChargingStandardsID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PYCode)
                .HasMaxLength(200);

            this.Property(t => t.BaoxianBtypeid)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("QP_RepairAutoInfo");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.ParID).HasColumnName("ParID");
            this.Property(t => t.Leveal).HasColumnName("Leveal");
            this.Property(t => t.SonCount).HasColumnName("SonCount");
            this.Property(t => t.SonNum).HasColumnName("SonNum");
            this.Property(t => t.PlateNumber).HasColumnName("PlateNumber");
            this.Property(t => t.EngineNumber).HasColumnName("EngineNumber");
            this.Property(t => t.BTypeID).HasColumnName("BTypeID");
            this.Property(t => t.RepairAutoTypeID).HasColumnName("RepairAutoTypeID");
            this.Property(t => t.FrameNumber).HasColumnName("FrameNumber");
            this.Property(t => t.TransmissionNumber).HasColumnName("TransmissionNumber");
            this.Property(t => t.VIN).HasColumnName("VIN");
            this.Property(t => t.Color).HasColumnName("Color");
            this.Property(t => t.RecordDate).HasColumnName("RecordDate");
            this.Property(t => t.ForceMaintainDate).HasColumnName("ForceMaintainDate");
            this.Property(t => t.ForceMaintainMileage).HasColumnName("ForceMaintainMileage");
            this.Property(t => t.FirstMaintainDate).HasColumnName("FirstMaintainDate");
            this.Property(t => t.FirstMaintainMileage).HasColumnName("FirstMaintainMileage");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.LeaveFactoryNum).HasColumnName("LeaveFactoryNum");
            this.Property(t => t.LeaveFactoryDate).HasColumnName("LeaveFactoryDate");
            this.Property(t => t.Driver).HasColumnName("Driver");
            this.Property(t => t.DriverMobilePhone).HasColumnName("DriverMobilePhone");
            this.Property(t => t.CardNumber).HasColumnName("CardNumber");
            this.Property(t => t.ChargingStandardsID).HasColumnName("ChargingStandardsID");
            this.Property(t => t.XiWaMaxNumber).HasColumnName("XiWaMaxNumber");
            this.Property(t => t.PYCode).HasColumnName("PYCode");
            this.Property(t => t.BaoxianBtypeid).HasColumnName("BaoxianBtypeid");
        }
    }
}
