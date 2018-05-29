using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class QP_PType_ExtMap : EntityTypeConfiguration<QP_PType_Ext>
    {
        public QP_PType_ExtMap()
        {
            // Primary Key
            this.HasKey(t => t.PTypeID);

            // Properties
            this.Property(t => t.PTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Brand)
                .HasMaxLength(100);

            this.Property(t => t.Import)
                .HasMaxLength(100);

            this.Property(t => t.GeneralType)
                .HasMaxLength(200);

            this.Property(t => t.GeneralDwgNo)
                .HasMaxLength(250);

            this.Property(t => t.Property)
                .HasMaxLength(100);

            this.Property(t => t.PackageQty)
                .HasMaxLength(100);

            this.Property(t => t.Weight)
                .HasMaxLength(100);

            this.Property(t => t.TaxNumber)
                .HasMaxLength(100);

            this.Property(t => t.BTypeID)
                .HasMaxLength(50);

            this.Property(t => t.FcUnit)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("QP_PType_Ext");
            this.Property(t => t.PTypeID).HasColumnName("PTypeID");
            this.Property(t => t.Brand).HasColumnName("Brand");
            this.Property(t => t.Import).HasColumnName("Import");
            this.Property(t => t.GeneralType).HasColumnName("GeneralType");
            this.Property(t => t.GeneralDwgNo).HasColumnName("GeneralDwgNo");
            this.Property(t => t.Property).HasColumnName("Property");
            this.Property(t => t.PackageQty).HasColumnName("PackageQty");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.TaxNumber).HasColumnName("TaxNumber");
            this.Property(t => t.Taxrate).HasColumnName("Taxrate");
            this.Property(t => t.BTypeID).HasColumnName("BTypeID");
            this.Property(t => t.FcUnit).HasColumnName("FcUnit");
            this.Property(t => t.FcPrice).HasColumnName("FcPrice");
        }
    }
}
