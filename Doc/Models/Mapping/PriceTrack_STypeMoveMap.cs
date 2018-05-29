using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PriceTrack_STypeMoveMap : EntityTypeConfiguration<PriceTrack_STypeMove>
    {
        public PriceTrack_STypeMoveMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.CID, t.UnitID, t.PTypeID, t.BillType, t.InSTypeID, t.OutStypeID, t.RecMovePrice });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InSTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OutStypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RecMovePrice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PriceTrack_STypeMove");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CID).HasColumnName("CID");
            this.Property(t => t.UnitID).HasColumnName("UnitID");
            this.Property(t => t.PTypeID).HasColumnName("PTypeID");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.InSTypeID).HasColumnName("InSTypeID");
            this.Property(t => t.OutStypeID).HasColumnName("OutStypeID");
            this.Property(t => t.RecMovePrice).HasColumnName("RecMovePrice");
            this.Property(t => t.Tax).HasColumnName("Tax");
            this.Property(t => t.TaxPrice).HasColumnName("TaxPrice");
            this.Property(t => t.DiscountRate).HasColumnName("DiscountRate");
            this.Property(t => t.TrackTime).HasColumnName("TrackTime");
        }
    }
}
