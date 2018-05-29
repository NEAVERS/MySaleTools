using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class vWeb_GuestGetMap : EntityTypeConfiguration<vWeb_GuestGet>
    {
        public vWeb_GuestGetMap()
        {
            // Primary Key
            this.HasKey(t => new { t.FullName, t.BillNumberId });

            // Properties
            this.Property(t => t.UserCode)
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PtypeId)
                .HasMaxLength(50);

            this.Property(t => t.jobnumber)
                .HasMaxLength(20);

            this.Property(t => t.comment)
                .HasMaxLength(255);

            this.Property(t => t.Unit1)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("vWeb_GuestGet");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.PtypeId).HasColumnName("PtypeId");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.SalePrice).HasColumnName("SalePrice");
            this.Property(t => t.discount).HasColumnName("discount");
            this.Property(t => t.DiscountPrice).HasColumnName("DiscountPrice");
            this.Property(t => t.costprice).HasColumnName("costprice");
            this.Property(t => t.jobnumber).HasColumnName("jobnumber");
            this.Property(t => t.goodsno).HasColumnName("goodsno");
            this.Property(t => t.total).HasColumnName("total");
            this.Property(t => t.OutFactoryDate).HasColumnName("OutFactoryDate");
            this.Property(t => t.TaxPrice).HasColumnName("TaxPrice");
            this.Property(t => t.TaxTotal).HasColumnName("TaxTotal");
            this.Property(t => t.comment).HasColumnName("comment");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.TeamNo1).HasColumnName("TeamNo1");
            this.Property(t => t.Unit1).HasColumnName("Unit1");
        }
    }
}
