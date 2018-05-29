using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class QP_nVipCardSign_RepairItems_Map : EntityTypeConfiguration<QP_nVipCardSign_RepairItems_>
    {
        public QP_nVipCardSign_RepairItems_Map()
        {
            // Primary Key
            this.HasKey(t => new { t.VipCardID, t.ID, t.RepairItemsTypeID, t.AllowUsedTimes, t.UsedTimes, t.Comment });

            // Properties
            this.Property(t => t.VipCardID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.RepairItemsTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AllowUsedTimes)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UsedTimes)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("QP_nVipCardSign_RepairItems ");
            this.Property(t => t.VipCardID).HasColumnName("VipCardID");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RepairItemsTypeID).HasColumnName("RepairItemsTypeID");
            this.Property(t => t.ManHour).HasColumnName("ManHour");
            this.Property(t => t.VIPPrice).HasColumnName("VIPPrice");
            this.Property(t => t.AllowUsedTimes).HasColumnName("AllowUsedTimes");
            this.Property(t => t.UsedTimes).HasColumnName("UsedTimes");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
