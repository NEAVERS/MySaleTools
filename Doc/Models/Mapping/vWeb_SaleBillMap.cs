using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class vWeb_SaleBillMap : EntityTypeConfiguration<vWeb_SaleBill>
    {
        public vWeb_SaleBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.FullName, t.BillNumberId, t.ID, t.isUnit2 });

            // Properties
            this.Property(t => t.UserCode)
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Unit1)
                .HasMaxLength(8);

            this.Property(t => t.Unit2)
                .HasMaxLength(8);

            this.Property(t => t.EntryCode)
                .HasMaxLength(200);

            this.Property(t => t.Standard)
                .HasMaxLength(200);

            this.Property(t => t.Type)
                .HasMaxLength(200);

            this.Property(t => t.Area)
                .HasMaxLength(200);

            this.Property(t => t.IfSerial)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.comment)
                .HasMaxLength(255);

            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.isUnit2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("vWeb_SaleBill");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Unit1).HasColumnName("Unit1");
            this.Property(t => t.Unit2).HasColumnName("Unit2");
            this.Property(t => t.UnitRate1).HasColumnName("UnitRate1");
            this.Property(t => t.UnitRate2).HasColumnName("UnitRate2");
            this.Property(t => t.EntryCode).HasColumnName("EntryCode");
            this.Property(t => t.Standard).HasColumnName("Standard");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Area).HasColumnName("Area");
            this.Property(t => t.IfSerial).HasColumnName("IfSerial");
            this.Property(t => t.qty).HasColumnName("qty");
            this.Property(t => t.SalePrice).HasColumnName("SalePrice");
            this.Property(t => t.TaxPrice).HasColumnName("TaxPrice");
            this.Property(t => t.TaxTotal).HasColumnName("TaxTotal");
            this.Property(t => t.comment).HasColumnName("comment");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.DiscountPrice).HasColumnName("DiscountPrice");
            this.Property(t => t.isUnit2).HasColumnName("isUnit2");
            this.Property(t => t.Serial).HasColumnName("Serial");
        }
    }
}
