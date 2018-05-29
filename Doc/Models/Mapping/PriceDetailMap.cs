using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PriceDetailMap : EntityTypeConfiguration<PriceDetail>
    {
        public PriceDetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.PriceBillIndexID, t.State, t.Ptypeid, t.UnitId });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.PriceBillIndexID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.State)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Ptypeid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UnitId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            this.Property(t => t.Checke)
                .HasMaxLength(50);

            this.Property(t => t.Checker)
                .HasMaxLength(50);

            this.Property(t => t.DeletedR)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PriceDetail");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PriceBillIndexID).HasColumnName("PriceBillIndexID");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Ptypeid).HasColumnName("Ptypeid");
            this.Property(t => t.FreeID).HasColumnName("FreeID");
            this.Property(t => t.IsCombined).HasColumnName("IsCombined");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.PriceStyle).HasColumnName("PriceStyle");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.DiscountPrice).HasColumnName("DiscountPrice");
            this.Property(t => t.BeforeRetailPrice).HasColumnName("BeforeRetailPrice");
            this.Property(t => t.Tax).HasColumnName("Tax");
            this.Property(t => t.TaxPrice).HasColumnName("TaxPrice");
            this.Property(t => t.IsPriceControl).HasColumnName("IsPriceControl");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Checke).HasColumnName("Checke");
            this.Property(t => t.Checker).HasColumnName("Checker");
            this.Property(t => t.VaildDate).HasColumnName("VaildDate");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.DeletedDate).HasColumnName("DeletedDate");
            this.Property(t => t.DeletedR).HasColumnName("DeletedR");
            this.Property(t => t.SortID).HasColumnName("SortID");
            this.Property(t => t.OldID).HasColumnName("OldID");
        }
    }
}
