using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class vWeb_OrderBillFromBillMap : EntityTypeConfiguration<vWeb_OrderBillFromBill>
    {
        public vWeb_OrderBillFromBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.billNumberId, t.OrderID, t.FullName });

            // Properties
            this.Property(t => t.billNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.fhdw)
                .HasMaxLength(66);

            this.Property(t => t.OrderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ptypeid)
                .HasMaxLength(50);

            this.Property(t => t.UserCode)
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.EntryCode)
                .HasMaxLength(200);

            this.Property(t => t.Standard)
                .HasMaxLength(200);

            this.Property(t => t.Type)
                .HasMaxLength(200);

            this.Property(t => t.Area)
                .HasMaxLength(200);

            this.Property(t => t.Unit1)
                .HasMaxLength(8);

            this.Property(t => t.Unit2)
                .HasMaxLength(8);

            this.Property(t => t.IfSerial)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.comment)
                .HasMaxLength(250);

            this.Property(t => t.CustomerCode)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("vWeb_OrderBillFromBill");
            this.Property(t => t.billNumberId).HasColumnName("billNumberId");
            this.Property(t => t.fhdw).HasColumnName("fhdw");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.qty).HasColumnName("qty");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.Tax).HasColumnName("Tax");
            this.Property(t => t.TaxPrice).HasColumnName("TaxPrice");
            this.Property(t => t.DiscountPrice).HasColumnName("DiscountPrice");
            this.Property(t => t.TaxTotal).HasColumnName("TaxTotal");
            this.Property(t => t.BigQty).HasColumnName("BigQty");
            this.Property(t => t.total).HasColumnName("total");
            this.Property(t => t.ReachQty).HasColumnName("ReachQty");
            this.Property(t => t.PassQty).HasColumnName("PassQty");
            this.Property(t => t.ptypeid).HasColumnName("ptypeid");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.EntryCode).HasColumnName("EntryCode");
            this.Property(t => t.Standard).HasColumnName("Standard");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Area).HasColumnName("Area");
            this.Property(t => t.Unit1).HasColumnName("Unit1");
            this.Property(t => t.Unit2).HasColumnName("Unit2");
            this.Property(t => t.UnitRate1).HasColumnName("UnitRate1");
            this.Property(t => t.UnitRate2).HasColumnName("UnitRate2");
            this.Property(t => t.IfSerial).HasColumnName("IfSerial");
            this.Property(t => t.serialcount).HasColumnName("serialcount");
            this.Property(t => t.validdays).HasColumnName("validdays");
            this.Property(t => t.comment).HasColumnName("comment");
            this.Property(t => t.CustomerCode).HasColumnName("CustomerCode");
            this.Property(t => t.IsUnit2).HasColumnName("IsUnit2");
        }
    }
}
