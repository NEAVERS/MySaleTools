using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Old_BillMulAccountMap : EntityTypeConfiguration<Old_BillMulAccount>
    {
        public Old_BillMulAccountMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.ID });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ATypeID)
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Old_BillMulAccount");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ATypeID).HasColumnName("ATypeID");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.VipCardID).HasColumnName("VipCardID");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.NTotalMoney).HasColumnName("NTotalMoney");
        }
    }
}
