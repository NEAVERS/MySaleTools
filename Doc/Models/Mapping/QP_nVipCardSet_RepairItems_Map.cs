using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class QP_nVipCardSet_RepairItems_Map : EntityTypeConfiguration<QP_nVipCardSet_RepairItems_>
    {
        public QP_nVipCardSet_RepairItems_Map()
        {
            // Primary Key
            this.HasKey(t => new { t.VipCardTypeID, t.ID, t.RepairItemsTypeID, t.RepairItemsType, t.AllowUsedTimes });

            // Properties
            this.Property(t => t.VipCardTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.RepairItemsTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RepairItemsType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AllowUsedTimes)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("QP_nVipCardSet_RepairItems ");
            this.Property(t => t.VipCardTypeID).HasColumnName("VipCardTypeID");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RepairItemsTypeID).HasColumnName("RepairItemsTypeID");
            this.Property(t => t.RepairItemsType).HasColumnName("RepairItemsType");
            this.Property(t => t.ManHour).HasColumnName("ManHour");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.VIPPrice).HasColumnName("VIPPrice");
            this.Property(t => t.AllowUsedTimes).HasColumnName("AllowUsedTimes");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
