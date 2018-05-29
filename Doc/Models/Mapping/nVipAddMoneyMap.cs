using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class nVipAddMoneyMap : EntityTypeConfiguration<nVipAddMoney>
    {
        public nVipAddMoneyMap()
        {
            // Primary Key
            this.HasKey(t => new { t.nID, t.CardId });

            // Properties
            this.Property(t => t.nID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CardId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ETypeId)
                .HasMaxLength(50);

            this.Property(t => t.ATypeId)
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            this.Property(t => t.Checke)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("nVipAddMoney");
            this.Property(t => t.nID).HasColumnName("nID");
            this.Property(t => t.CardId).HasColumnName("CardId");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.ETypeId).HasColumnName("ETypeId");
            this.Property(t => t.aMoney).HasColumnName("aMoney");
            this.Property(t => t.ATypeId).HasColumnName("ATypeId");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Checke).HasColumnName("Checke");
            this.Property(t => t.TotalInMoney).HasColumnName("TotalInMoney");
            this.Property(t => t.PreferenceMoney).HasColumnName("PreferenceMoney");
        }
    }
}
