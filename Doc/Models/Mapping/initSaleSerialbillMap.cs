using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class initSaleSerialbillMap : EntityTypeConfiguration<initSaleSerialbill>
    {
        public initSaleSerialbillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Serial });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Serial)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.KtypeID)
                .HasMaxLength(50);

            this.Property(t => t.PtypeID)
                .HasMaxLength(50);

            this.Property(t => t.BTypeID1)
                .HasMaxLength(50);

            this.Property(t => t.BtypeID2)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("initSaleSerialbill");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BillNumerID).HasColumnName("BillNumerID");
            this.Property(t => t.Serial).HasColumnName("Serial");
            this.Property(t => t.KtypeID).HasColumnName("KtypeID");
            this.Property(t => t.PtypeID).HasColumnName("PtypeID");
            this.Property(t => t.BTypeID1).HasColumnName("BTypeID1");
            this.Property(t => t.BtypeID2).HasColumnName("BtypeID2");
            this.Property(t => t.InKtypeTime).HasColumnName("InKtypeTime");
            this.Property(t => t.OutKTypeTime).HasColumnName("OutKTypeTime");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
