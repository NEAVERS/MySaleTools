using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PriceTrack_AppraisalMap : EntityTypeConfiguration<PriceTrack_Appraisal>
    {
        public PriceTrack_AppraisalMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BTypeID, t.BTypeFlag, t.PTypeID, t.STypeID, t.Price, t.DiscountRate, t.DiscountPrice, t.UID, t.CID });

            // Properties
            this.Property(t => t.BTypeID)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.BTypeFlag)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.STypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Price)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DiscountRate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DiscountPrice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PriceTrack_Appraisal");
            this.Property(t => t.BTypeID).HasColumnName("BTypeID");
            this.Property(t => t.BTypeFlag).HasColumnName("BTypeFlag");
            this.Property(t => t.PTypeID).HasColumnName("PTypeID");
            this.Property(t => t.STypeID).HasColumnName("STypeID");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.DiscountRate).HasColumnName("DiscountRate");
            this.Property(t => t.DiscountPrice).HasColumnName("DiscountPrice");
            this.Property(t => t.UID).HasColumnName("UID");
            this.Property(t => t.CID).HasColumnName("CID");
            this.Property(t => t.Tax).HasColumnName("Tax");
            this.Property(t => t.TaxPrice).HasColumnName("TaxPrice");
            this.Property(t => t.TrackTime).HasColumnName("TrackTime");
        }
    }
}
