using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class FZ_InOutColorSizeMap : EntityTypeConfiguration<FZ_InOutColorSize>
    {
        public FZ_InOutColorSizeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillDate, t.BillNumberID, t.BillType, t.ColorID, t.SizeID, t.IfCheck });

            // Properties
            this.Property(t => t.BillNumberID)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.BillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PtypeID)
                .HasMaxLength(50);

            this.Property(t => t.KtypeID)
                .HasMaxLength(50);

            this.Property(t => t.ColorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SizeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IfCheck)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("FZ_InOutColorSize");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.BillNumberID).HasColumnName("BillNumberID");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.PtypeID).HasColumnName("PtypeID");
            this.Property(t => t.KtypeID).HasColumnName("KtypeID");
            this.Property(t => t.ColorID).HasColumnName("ColorID");
            this.Property(t => t.SizeID).HasColumnName("SizeID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.IfCheck).HasColumnName("IfCheck");
        }
    }
}
