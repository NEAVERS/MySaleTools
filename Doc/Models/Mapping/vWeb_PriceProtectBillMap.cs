using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class vWeb_PriceProtectBillMap : EntityTypeConfiguration<vWeb_PriceProtectBill>
    {
        public vWeb_PriceProtectBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberID, t.FullName, t.Serial, t.ID });

            // Properties
            this.Property(t => t.BillNumberID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.typeid)
                .HasMaxLength(50);

            this.Property(t => t.UserCode)
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Serial)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(255);

            this.Property(t => t.Base)
                .HasMaxLength(255);

            this.Property(t => t.customitemid)
                .HasMaxLength(20);

            this.Property(t => t.customitemfrom)
                .HasMaxLength(20);

            this.Property(t => t.goodsnumber)
                .HasMaxLength(100);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("vWeb_PriceProtectBill");
            this.Property(t => t.BillNumberID).HasColumnName("BillNumberID");
            this.Property(t => t.typeid).HasColumnName("typeid");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Oldtotal).HasColumnName("Oldtotal");
            this.Property(t => t.Serial).HasColumnName("Serial");
            this.Property(t => t.OldPrice).HasColumnName("OldPrice");
            this.Property(t => t.NewPrice).HasColumnName("NewPrice");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.ntotal).HasColumnName("ntotal");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Base).HasColumnName("Base");
            this.Property(t => t.itemid).HasColumnName("itemid");
            this.Property(t => t.IsCombined).HasColumnName("IsCombined");
            this.Property(t => t.itemname).HasColumnName("itemname");
            this.Property(t => t.customitemid).HasColumnName("customitemid");
            this.Property(t => t.customitemfrom).HasColumnName("customitemfrom");
            this.Property(t => t.customitemname).HasColumnName("customitemname");
            this.Property(t => t.customitemrefid).HasColumnName("customitemrefid");
            this.Property(t => t.goodsnumber).HasColumnName("goodsnumber");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.IfUseGoodsNum).HasColumnName("IfUseGoodsNum");
        }
    }
}
