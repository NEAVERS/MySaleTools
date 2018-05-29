using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PriceBillIndexMap : EntityTypeConfiguration<PriceBillIndex>
    {
        public PriceBillIndexMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.UserCode, t.FullName, t.CID, t.IsFreePrice, t.IsUnitPrice, t.IsDiscount, t.IsRate, t.BillType, t.PosDataVersion });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.UserCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.CID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Explain)
                .HasMaxLength(256);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            this.Property(t => t.BillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Checke)
                .HasMaxLength(50);

            this.Property(t => t.PosDataVersion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("PriceBillIndex");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.CID).HasColumnName("CID");
            this.Property(t => t.IsFreePrice).HasColumnName("IsFreePrice");
            this.Property(t => t.IsUnitPrice).HasColumnName("IsUnitPrice");
            this.Property(t => t.IsDiscount).HasColumnName("IsDiscount");
            this.Property(t => t.IsRate).HasColumnName("IsRate");
            this.Property(t => t.Explain).HasColumnName("Explain");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Checke).HasColumnName("Checke");
            this.Property(t => t.XiWaMaxNumber).HasColumnName("XiWaMaxNumber");
            this.Property(t => t.PosDataVersion).HasColumnName("PosDataVersion");
        }
    }
}
