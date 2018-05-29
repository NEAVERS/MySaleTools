using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class QP_nVipAddWashTimesMap : EntityTypeConfiguration<QP_nVipAddWashTimes>
    {
        public QP_nVipAddWashTimesMap()
        {
            // Primary Key
            this.HasKey(t => t.nID);

            // Properties
            this.Property(t => t.CardId)
                .HasMaxLength(50);

            this.Property(t => t.ETypeId)
                .HasMaxLength(50);

            this.Property(t => t.ATypeId)
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("QP_nVipAddWashTimes");
            this.Property(t => t.nID).HasColumnName("nID");
            this.Property(t => t.CardId).HasColumnName("CardId");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.ETypeId).HasColumnName("ETypeId");
            this.Property(t => t.aMoney).HasColumnName("aMoney");
            this.Property(t => t.TotalInMoney).HasColumnName("TotalInMoney");
            this.Property(t => t.PreferenceMoney).HasColumnName("PreferenceMoney");
            this.Property(t => t.AddTimes).HasColumnName("AddTimes");
            this.Property(t => t.ATypeId).HasColumnName("ATypeId");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
